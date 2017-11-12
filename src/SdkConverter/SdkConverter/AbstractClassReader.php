<?php

/**
 * Namespace
 * @copyright (c) 2016 | Searchresult Performancemarketing
 */
namespace SdkConverter;

/**
 * Check if the application has been initialized
 */
if (defined("__SDK_CONVERTER__") == false) exit("Application not initialized");

/**
 * Use classes
 */
use \ReflectionClass;

/**
 * Class AbstractClassReader
 * @package SdkConverter
 * @author  Paradoxis <luke@paradoxis.nl>
 */
abstract class AbstractClassReader
{
    /**
     * Class namespace passed by the Converter
     * @var string
     */
    protected $namespace;

    /**
     * Class name passed by the Converter
     * @var string
     */
    protected $name;

    /**
     * Filename of the class passed by the Converter
     * @var string
     */
    protected $file;

    /**
     * Path and filename of the class passed by the Converter
     * @var string
     */
    protected $path;

    /**
     * ReflectionClass instance which gives us information about our class
     * @var \ReflectionClass
     */
    protected $reflection;

    /**
     * Method blacklist
     * Mostly inherited methods etc
     * @var string[]
     */
    protected $methodBlacklist = [
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
        "getProductFromCatalogByRetailerId",
        "getReferencedEnums",
        "getFieldTypes"
    ];

    /**
     * Constructor method
     * @param string $namespace
     * @param string $name
     * @param string $file
     * @param string $path
     */
    public function __construct($namespace, $name, $file, $path)
    {
        // Load values into their variables
        $this->namespace = $namespace;
        $this->name = $name;
        $this->file = $file;
        $this->path = $path;

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
    public function getClassName()
    {
        return $this->name;
    }

    /**
     * Gets the class name assigned to the module
     * @return string
     */
    public function getClassNamespace()
    {
        return $this->namespace;
    }

    /**
     * Gets the filename of the class assigned to the module
     * @return string
     */
    public function getFileName()
    {
        return $this->file;
    }

    /**
     * Gets the file path of the class assigned to the module
     * @return string
     */
    public function getFilePath()
    {
        return $this->path;
    }


    /**
     * Get the name of the (sub)class
     * @return string
     */
    public static function className() {
        return get_called_class();
    }


    /**
     * Get the output directory path
     * @return string
     * @abstract
     */
    public abstract function getOutputLocation();

    /**
     * Get the output file path
     * @return string
     * @abstract
     */
    public abstract function getOutputFileLocation();

    /**
     * Get the template file path
     * @return string
     * @abstract
     */
    public abstract function getTemplateLocation();
}
