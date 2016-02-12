# Facebook Ads API SDK for C-sharp

This Ads API SDK is built to facilitate application development for [Facebook Ads API](https://developers.facebook.com/docs/ads-api).

## Installation

**C-Sharp Library**

1. Open the code in a visual studio project and add the unofficial [Facebook C-Sharp SDK](https://github.com/facebook-csharp-sdk/facebook-csharp-sdk) library by going to *FacebookAds->References->Manage NuGet Packages*
2. Look for *Facebook* and press *Install*
3. Open your project and import the main class and use the `static void FacebookAds.Api.Init(appId, appSecret, accessToken)` method to initialize the library for use.

**PHP SdkConverter**

1. Download the official [Facebook Ads PHP SDK](https://github.com/facebook/facebook-php-ads-sdk) from the officical Facebook github and place it in `/lib/`
2. Download the official [Facebook PHP SDK autoloader](https://github.com/facebook/facebook-php-sdk-v4/blob/master/src/Facebook/autoload.php) and place it in `/lib/FacebookAds/` and change the `$prefix` variable to `'FacebookAds\\'` on line 47.
3. Run the main PHP script `/src/SdkConverter/main.php` to generate your `.cs` files


## Usage

The entire library is built to be as similar to the official PHP SDK as possible, so the names and method calls are the same. Refer to the official [documentation](https://developers.facebook.com/docs/marketing-api/reference/) for more information.