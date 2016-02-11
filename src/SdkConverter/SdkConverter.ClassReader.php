<?php

/**
 * Namespace
 * @copyright (c) 2014 - 2016 | Paradoxis
 */
namespace SdkConverter;

/**
 * Use classes
 */
use \InvalidArgumentException;
use \ReflectionClass;
use \stdClass;

/**
 * Class ClassReader
 * @package SdkConverter
 * @author  Paradoxis <luke@paradoxis.nl>
 */
class ClassReader {

    /**
     * Class namespace passed by the Converter
     * @var string
     */
    private $namespace;

    /**
     * Class name passed by the Converter
     * @var string
     */
    private $name;

    /**
     * Filename of the class passed by the Converter
     * @var string
     */
    private $file;

    /**
     * Path and filename of the class passed by the Converter
     * @var string
     */
    private $path;

    /**
     * ReflectionClass instance which gives us information about our class
     * @var \ReflectionClass
     */
    private $reflection;


    /**
     * Method blacklist
     * Mostly inherited methods etc
     * @var string[]
     */
    private $methodBlacklist = [
        "getEndpoint",
        "getFieldsEnum",
        "getFields",
        "getData",
        "getManyByConnection",
        "getOneByConnection",
        "getNodePath",
        "getDefaultReadFields",
        "getChangedFields",
        "getChangedValues",
        "getApi",
        "getParentId",
        "getStatusParamName",
        "getResult",
        "getConnectedObjects",
        "getCreateIdFieldName",
        "getCompletitionPercentageFieldName",
        "getNormalizers",
        "getProductFromCatalogByRetailerId"
    ];


    /**
     * Constructor method
     * @param stdClass $class
     */
    public function __construct(stdClass $class) {

        // Load the class details into their respected variables
        foreach(['namespace', 'name', 'file', 'path'] as $field) {
            if (isset($class->$field) && is_string($class->$field)) {
                $this->$field = $class->$field;
            } else {
                throw new InvalidArgumentException("Invalid field '$field' supplied.");
            }
        }

        // Include the file and store it in a reflection instance
        // Is this potentially dangerous with unknown PHP files?
        // Yes. Yes it is.
        // But who gives, it's facebook.
        $this->reflection = new ReflectionClass($this->namespace);
    }

    /**
     * Gets the class name assigned to the module
     * @return string
     */
    public function getClassName() {
        return $this->name;
    }

    /**
     * Gets the filename of the class assigned to the module
     * @return string
     */
    public function getFileName() {
        return $this->file;
    }

    /**
     * Gets the file path of the class assigned to the module
     * @return string
     */
    public function getFilePath() {
        return $this->path;
    }

    /**
     * Gets the endpoint of the API call
     * @return string
     */
    public function getEndPoint() {
        if ($this->reflection->hasMethod('getEndpoint')) {
            $method = $this->reflection->getMethod('getEndpoint');
            $method->setAccessible(true);
            return $method->invoke(new $this->namespace);
        } else {
            return "";
        }
    }

    /**
     * Get all methods as a MethodReader array
     * @return \SdkConverter\MethodReader[]
     */
    public function getMethods() {
        $readers = [];

        foreach($this->reflection->getMethods() as $method) {
            if (substr($method->name, 0, 3) == "get" && in_array($method->name, $this->methodBlacklist) == false) {
                $readers[] = new MethodReader($method);
            }
        }

        return $readers;
    }
}