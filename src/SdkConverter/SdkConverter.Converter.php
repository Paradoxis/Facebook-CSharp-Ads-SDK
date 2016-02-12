<?php

/**
 * Namespace
 * @copyright (c) 2014 - 2016 | Paradoxis
 */
namespace SdkConverter;

/**
 * Use classes
 */
use \Exception;
use \stdClass;
use \SdkConverter\AbstractClassReader as ClassReader;
use \SdkConverter\Object\ClassReader as ObjectClassReader;
use \SdkConverter\Fields\ClassReader as FieldsClassReader;

/**
 * Class Converter
 * @package SdkConverter
 * @author  Paradoxis <luke@paradoxis.nl>
 */
class Converter
{
    /**
     * The class directories we want to read from
     * @var string
     */
    const INPUT_DIR_OBJECT = "/../../lib/FacebookAds/Object/";
    const INPUT_DIR_FIELDS = "/../../lib/FacebookAds/Object/Fields/";

    /**
     * Output directories where we want our classes to go
     * @var string
     */
    const OUTPUT_DIR_OBJECT = "/Output/";
    const OUTPUT_DIR_FIELDS = "/Output/Fields/";

    /**
     * Class namespaces
     * @var string
     */
    const CLASS_NAMESPACE_OBJECT = "\\FacebookAds\\Object\\";
    const CLASS_NAMESPACE_FIELDS = "\\FacebookAds\\Object\\Fields\\";

    /**
     * Every available file in the directory
     * @var \SdkConverter\AbstractClassReader[]
     */
    public $classes = [];

    /**
     * Blacklist of files we DON'T want to convert
     * These are helper classes or interfaces which don't serve as API objects
     * @var array
     */
    private $blacklist = [
        "AbstractArchivableCrudObjectFields.php",
        "AbstractArchivableCrudObject.php",
        "AbstractAsyncJobObject.php",
        "AbstractCrudObject.php",
        "AbstractObject.php",
        "CanRedownloadInterface.php"
    ];

    /**
     * Class constructor
     * Loads all files into the $file array
     */
    public function __construct()
    {
        $this->loadClasses(__DIR__.self::INPUT_DIR_OBJECT, self::CLASS_NAMESPACE_OBJECT, ObjectClassReader::className());
        $this->loadClasses(__DIR__.self::INPUT_DIR_FIELDS, self::CLASS_NAMESPACE_FIELDS, FieldsClassReader::className());
    }

    /**
     * Loads classes by scanning a directory
     * @param string $dir
     * @param string $namespace
     * @param string $class
     * @throws Exception
     */
    private function loadClasses($dir, $namespace, $class)
    {
        // Check if directory exists
        if (file_exists($dir) == false || is_dir($dir) == false) {
            throw new Exception("Directory '$dir' not found or is not a valid directory!");
        }

        // Scan the directory and load the classes in
        foreach(scandir($dir) as $file) {
            if(
                is_file($dir.$file) &&
                in_array($file, $this->blacklist) == false
            ) {

                // Generate a new instance of
                $instance = new $class(
                    $namespace.explode(".", $file)[0],
                    explode(".", $file)[0],
                    $file,
                    $dir.$file
                );

                // Load instance into the classes array
                if ($instance instanceof AbstractClassReader) {
                    $this->classes[] = $instance;
                } else {
                    throw new Exception("Class $class must be an instance of SdkConverter\\AbstractClassReader!");
                }

                // Give debug information back
                if (__DEBUG__) {
                    echo "Found class file: ".$dir.$file."\n";
                }
            }
        }
    }

    /**
     * Returns the amount of classes that have been loaded into the compiler
     * @return int
     */
    public function getClassCount()
    {
        return count($this->classes);
    }

    /**
     * Compiles all PHP classes to their respected C# variant
     * @return void
     */
    public function compile()
    {
        // Display header information
        $start = microtime(true);
        echo "SdkConverter | Facebook Ads SDK to C# converter \n";
        echo "Copyright (c) 2014 - " . date('Y') . " | Luke Paris (Paradoxis) \n";
        echo "\n";
        echo "Starting compiler at " . date('Y-m-d H:i:s') . "\n";
        echo "---------------------------------------- \n";

        // Compile each class
        foreach($this->classes as $class) {
            $this->compileFile($class);
        }

        // Display duration
        $duration = round(microtime(true) - $start, 4);
        echo "---------------------------------------- \n";
        echo "Compiler finished in $duration seconds and generated {$this->getClassCount()} classes.";
    }

    /**
     * Compiles a single file using an Abstract Class Reader object
     * Class variable used in the templates
     * @param AbstractClassReader $class
     * @return void
     */
    private function compileFile(AbstractClassReader $class)
    {
        // Start output buffering and include the template class
        ob_start();
        include($class->getTemplateLocation());

        // Check if directory exists
        if (file_exists($class->getOutputLocation())) {
            if (is_dir($class->getOutputLocation()) == false) {
                mkdir($class->getOutputLocation());
            }
        } else {
            mkdir($class->getOutputLocation());
        }

        // Put output into the correct directory
        file_put_contents($class->getOutputFileLocation(), ob_get_contents());
        ob_end_clean();

        // Display that the class has been created
        echo "File saved to: {$class->getOutputFileLocation()} \n";
    }
}