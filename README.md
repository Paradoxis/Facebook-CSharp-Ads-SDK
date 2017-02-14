# Facebook Ads API SDK for C-sharp
The Facebook C# Ads SDK is a library to facilitate application development for [Facebook Ads API](https://developers.facebook.com/docs/ads-api). This repository consists of two parts: a ready to use C# library, and a compiler that converts the official Facebook PHP SDK into C# classes. For more information about either of the two parts, please refer to the documentation down below.

## Table of contents
* Using the C# library
  * Integrating the C# code into your own project
  * Installing the required dependencies
  * Understanding the classes and namespaces
  * Code examples
  
* Using the PHP to C# compiler
  * Some clarifications
  * Installing the required dependencies
  * Running the compiler

## Using the C# library
### Integrating the C# code into your own project
To integrate the C# code into your own project, add it as an existing project into your own solution like so:
* In your solution, right click inside the *Solution Explorer* and select *Add -> Existing project...*
* Navigate to where you cloned/downloaded this repository
* Enter the directory `/src/FacebookAds/FacebookAds/` and select the `FacebookAds.csproj` file
* Double click it, and you should now see the project files as a seperate project inside your solution!
* Now in your own project, right click the *References* section and select *Add reference*
* You should now see the *Reference manager*, select the tab *Project* and make sure the *FacebookAds* checkbox is checked

### Installing the required dependencies
The C# ads SDK makes use of the unofficial [Facebook SDK for C#](https://github.com/facebook-csharp-sdk/facebook-csharp-sdk) (not to be confused with this library) to make requests to the Facebook graph API and authenticate the SDK, and the [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json) library to parse the API responses. To install them, follow these steps:
* In your solution, right click the *FacebookAds* project and select *Manage NuGet Packages*
* In the search field:
  * Look for **Facebook** and press *Install*
  * Look for **Newtonsoft.Json** and press *Install*

Once you've done all of this, you should now be able to use the FacebookAds library from within your project!

### Understanding the classes and namespaces
The entire library is built to be as similar to the official PHP SDK as possible, so the names and method calls are the same. All objects almost identical to how they would in the PHP SDK, with the only difference being that you're using C# notation instead. For examples, please refer to the next paragraph. 

If you get stuck on writing code, refer to the official [documentation](https://developers.facebook.com/docs/marketing-api/reference/) for more information, I'm not an expert at using the Graph API. **Issues regarding how the Graph API works will be not be addressed**.

### Code examples
As previously mentioned, the SDK is built to be used exactly like the official PHP SDK. An example of this would be initializing the the `FacebookAds.API` class:

In PHP, you would initialize the API like so:

```php
<?php
use FacebookAds\Api;
Api::init($app_id, $app_secret, $access_token);
```

In this C# library, you would initialize the API like so:

```C#
using FacebookAds;
Api.Initialize(APP_ID, APP_SECRET, ACCESS_TOKEN);
```


## Using the PHP to C# compiler
### Some clarifications
As I've gotten numerous emails about the PHP to C# compiler, I will explain what it *is*, but most importantly what it *is not*. 

The compiler is **NOT** a generic cookie-cut PHP to C# compiler, it's soley built for the Facebook PHP Ads SDK. Building a PHP to C# compiler would require a lot more effort, and would have it's own dedicated repository. This compiler simply uses [reflection](https://en.wikipedia.org/wiki/Reflection_(computer_programming)) to read out all attributes from the PHP SDK, which it them passes to C# class templates that are then parsed to create working code.

The only reason you would want to use this, is to get an up-to-date version of the C# classes to work with the current API version. Other than that you aren't required to use them at all, you can simply follow the instructions above and load the pre-generated classes into your project.

A word of warning, these themplates aren't pretty. Cross-language source code almost never looks good, this is no exception. If you really want to feed your morbid curiosity of what they look like, [here you go](src/SdkConverter/SdkConverter/Templates/).

### Installing the required dependencies
First off, ensure you have the latest version of PHP installed, altough this script should be compatible with *PHP 5.X*+.

Since the compiler uses reflection on the actual Facebook PHP Ads SDK, it's required as a dependency for the compiler to function at all (automatic download might be added in the future if I ever feel like adding it, essentially eliminating this step).

* Download the official [Facebook Ads PHP SDK](https://github.com/facebook/facebook-php-ads-sdk) from the officical Facebook github and place it in the `/lib/` directory in the root of the cloned repository (the directory has already been created, it only contains a *.gitignore* file).
* Download the official [Facebook PHP SDK autoloader](https://github.com/facebook/facebook-php-sdk-v4/blob/master/src/Facebook/autoload.php) and place it in `/lib/FacebookAds/` and change the `$prefix` variable to `'FacebookAds\\'` on line 47.

### Running the compiler
The compiler is a single PHP script located at *[/src/SdkConverter/main.php](src/SdkConverter/main.php)*. This script is meant to be run using PHP's CLI mode, meaning you need a PHP version installed on your machine, and run the script from the command line (it's about time you learned how to use it anyway). You could also run it from a web server that has PHP installed, however it's not recommended as it might cause accidental side effects.

Running the script is easy, simply navigate your command prompt to the script location, run the main script and you're done!

    $ cd src/SdkConverter/
    $ php main.php

The compiler should now have created a bunch of classes and it will have written them to the directory: `/src/SdkConverter/Output/`

## License

The MIT License (MIT)

Copyright (c) 2016 - Luke Paris (Paradoxis) | Searchresult Performancemarketing

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
