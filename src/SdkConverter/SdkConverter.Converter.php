<?php

/**
 * Namespace
 * @copyright (c) 2014 - 2016 | Paradoxis
 */
namespace SdkConverter;

/**
 * Use classes
 */
use \stdClass;

/**
 * Class Converter
 * @package SdkConverter
 * @author  Paradoxis <luke@paradoxis.nl>
 */
class Converter
{
    /**
     * The class directory we want to read from
     * @var string
     */
    const INPUT_DIR = "/../../lib/FacebookAds/Object/";

    /**
     * Output directory where we want our classes to go
     * @var string
     */
    const OUTPUT_DIR = "/Output/";

    /**
     * Class namespace
     * @var string
     */
    const CLASS_NAMESPACE = "\\FacebookAds\\Object\\";

    /**
     * Every available file in the directory
     * @var stdClass[]
     */
    public $files = [];

    /**
     * Blacklist of files we DON'T want to convert
     * These are helper classes or interfaces which don't serve as API objects
     * @var array
     */
    private $blacklist = [
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
    public function __construct() {
        $dir = __DIR__.self::INPUT_DIR;

        foreach(scandir($dir) as $file) {
            if(
                is_file($dir.$file) &&
                in_array($file, $this->blacklist) == false
            ) {
                $this->files[] = (object) [
                    'namespace' => self::CLASS_NAMESPACE.explode(".", $file)[0],
                    'name' => explode(".", $file)[0],
                    'file' => $file,
                    'path' => $dir.$file,
                ];

                if (__DEBUG__) {
                    echo $dir.$file . "\n";
                }
            }
        }
    }

    /**
     * Get an array with class readers to parse the SDK classes
     * @return \SdkConverter\ClassReader[]
     */
    public function getClasses() {
        $classes = [];

        foreach($this->files as $file) {
            $classes[] = new ClassReader($file);
        }

        return $classes;
    }

    /**
     * Compiles all PHP classes to their respected C# variant
     * @return void
     */
    public function compile() {
        foreach($this->getClasses() as $class) {
            $output_location = __DIR__.self::OUTPUT_DIR."{$class->getClassName()}.cs";

            ob_start();
            include(__DIR__."/SdkConverter.ClassTemplate.php");
            file_put_contents($output_location, ob_get_contents());
            ob_end_clean();

            echo "File saved to: {$output_location} \n";
        }
    }
}