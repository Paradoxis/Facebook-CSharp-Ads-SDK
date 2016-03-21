<?php

/**
 * Namespace
 * @copyright (c) 2014 - 2016 | Searchresult
 */
namespace SdkConverter\Values;

/**
 * Check if the application has been initialized
 */
if (defined("__SDK_CONVERTER__") == false) exit("Application not initialized");

/**
 * Use classes
 */
use \SdkConverter\Converter;
use \SdkConverter\AbstractClassReader;

/**
 * Class ClassReader
 * @package SdkConverter\Values
 * @author  Paradoxis <luke@paradoxis.nl>
 */
class ClassReader extends AbstractClassReader
{
    /**
     * Get the output directory path
     * @return string
     */
    public function getOutputLocation()
    {
        return realpath(__DIR__.'/../..').Converter::OUTPUT_DIR_VALUES;
    }

    /**
     * Get the output directory path
     * @return string
     */
    public function getOutputFileLocation()
    {
        return realpath(__DIR__.'/../..').Converter::OUTPUT_DIR_VALUES."{$this->getClassName()}.cs";
    }

    /**
     * Get the template file path
     * @return string
     */
    public function getTemplateLocation()
    {
        return __DIR__.'/../Templates/FacebookAds.Object.Values.php';
    }

    /**
     * Get all methods as a MethodReader array
     * @return array
     */
    public function getConstants()
    {
        return $constants = $this->reflection->getConstants();
    }
}