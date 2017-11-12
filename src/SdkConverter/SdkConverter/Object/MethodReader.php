<?php

/**
 * Namespace
 * @copyright (c) 2016 | Searchresult Performancemarketing
 */
namespace SdkConverter\Object;

/**
 * Check if the application has been initialized
 */
if (defined("__SDK_CONVERTER__") == false) exit("Application not initialized");

/**
 * Use classes
 */
use \ReflectionMethod;

/**
 * Class MethodReader
 * @package SdkConverter
 * @author  Paradoxis <luke@paradoxis.nl>
 */
class MethodReader {

    /**
     * Method types
     * Methods are called directly via strings or via a dynamic reflection method
     * This means a direct call will have 4 parameters and a reflection call will have 3 (thus the numbers)
     * @var int
     */
    const TYPE_DIRECT = 4;
    const TYPE_REFLECTION = 3;

    /**
     * ReflectionMethod instance of a method used in API calls
     * @var \ReflectionMethod
     */
    private $method;

    /**
     * Class constructor
     * @param ReflectionMethod $method
     */
    public function __construct(ReflectionMethod $method) {
        $this->method = $method;
    }

    /**
     * Gets the body of a method as a string using reflection
     * @return string
     */
    private function getMethodBody() {
        $filename = $this->method->getFileName();

        $start_line = $this->method->getStartLine() - 1; // it's actually - 1, otherwise you wont get the function() block
        $end_line = $this->method->getEndLine();
        $length = $end_line - $start_line;

        $source = file($filename);
        $body = implode("", array_slice($source, $start_line, $length));
        return $body;
    }

    /**
     * Get the method endpoint
     * @return string[]
     */
    public function getMethodEndpoint() {
        $body = $this->getMethodBody();                         // Fetch method body
        $body = preg_replace("/\s\s+/", "", $body);             // Replaces all tabs and double spaces
        preg_match("/ApiRequest\((.*)\)\);/", $body, $body);    // Get the method parameters

        // Check for methods that don't match the default pattern
        // which is used in the auto-generated methods
        if (count($body) < 1) {
            error_log("Method conflict at: {$this->method->name}() in class {$this->method->class} (add this to the blacklist in Converter.ClassReader)");
            return null;
        }

        // Get the endpoint
        $body = explode(",", $body[1]);
        return ltrim(str_replace(["'", '"'], "", $body[3]), "/");
    }

    /**
     * Get pascal case version of the method name
     * @return string
     */
    public function getMethodName() {
        return ucfirst($this->method->name);
    }

    public function getDocumentation() {

        // Split the word with camel/pascal casing
        preg_match_all('/((?:^|[A-Z])[a-z]+)/', $this->method->name, $words);

        // Loop over all the words
        // Decapitalize all words by default
        // Change the first word to "Gets the"
        foreach($words[0] as $index => $word) {
            $word = strtolower($word);

            if ($index == 0) {
                if ($word == "get") {
                    $word = "Gets the";
                } else {
                    error_log("Method conflict at: {$this->method->name}() in class {$this->method->class} (method doesn't start with get???)");
                }
            }

            if ($word == "async") {
                $word = "asynchronously";
            }

            $words[$index] = $word;
        }

        // Join the entire method name as a sentence and return it
        return implode(" ", $words);
    }

    /**
     * Checks if the method is asynchronous
     * @return bool
     */
    public function isAsync() {
        return (strpos(strtolower($this->getMethodName()), 'async') !== false);
    }

    /**
     * Gets the connection method used by the API call
     * Asynchronous or non-synchronous
     * @return string
     */
    public function getConnectionMethod() {
        return ($this->isAsync()) ? "getManyByConnectionAsync" : "getManyByConnection";
    }
}