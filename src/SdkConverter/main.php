<?php

/**
 * PHP to C# Converter
 * Converts the entire Facebook Ads SDK to C# classes in our code
 *
 * This program is meant to be run via the CLI interface but should work fine with
 * a web-server as it doesn't use the stdin() method (yet).
 *
 * @author Luke Paris (Paradoxis) <luke@paradoxis.nl>
 * @copyright 2016 | Searchresult Performancemarketing
 */

// Define our converter constant to prevent bugs
define("__CONVERTER__", true);
define("__DEBUG__", false);

// Include Facebook autoloader and API class
// Download these from the official Facebook Ads SDK page
// @see https://github.com/facebook/facebook-php-ads-sdk
require_once(__DIR__."/../../lib/FacebookAds/Api.php");
require_once(__DIR__."/../../lib/FacebookAds/autoload.php");

// Include classes
require_once("SdkConverter.AbstractClassReader.php");
require_once("SdkConverter.Object.MethodReader.php");
require_once("SdkConverter.Object.ClassReader.php");
require_once("SdkConverter.Fields.ClassReader.php");
require_once("SdkConverter.Converter.php");

/**
 * Gets standard input from the user
 * PHP CLI input like a boss
 * @return string
 */
function stdin() {
    $handle = fopen ("php://stdin","r");
    $line = fgets($handle);
    return trim($line);
}

/**
 * Main entry point of the application
 * @return void
 */
function main() {
    \FacebookAds\Api::init("", "", ""); // #dat hack
    $converter = new \SdkConverter\Converter();
    $converter->compile();
}

// Everything is initialized
// Awesome, run this baby
main();