<?php

/**
 * Namespace
 * @copyright (c) 2014 - 2016 | Paradoxis
 */
namespace SdkConverter\Object;

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
 * @package SdkConverter
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
        return realpath(__DIR__.'/../..').Converter::OUTPUT_DIR_OBJECT;
    }

    /**
     * Get the output file path
     * @return string
     */
    public function getOutputFileLocation()
    {
        return realpath(__DIR__.'/../..').Converter::OUTPUT_DIR_OBJECT."{$this->getClassName()}.cs";
    }

    /**
     * Get the template file path
     * @return string
     */
    public function getTemplateLocation()
    {
        return __DIR__.'/../Templates/FacebookAds.Object.php';
    }

    /**
     * Gets the endpoint of the API call
     * @return string
     */
    public function getEndPoint()
    {
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
     * @return \SdkConverter\Object\MethodReader[]
     */
    public function getMethods()
    {
        $readers = [];

        foreach($this->reflection->getMethods() as $method) {
            if (substr($method->name, 0, 3) == "get" && in_array($method->name, $this->methodBlacklist) == false) {
                $readers[] = new MethodReader($method);
            }
        }

        return $readers;
    }
}