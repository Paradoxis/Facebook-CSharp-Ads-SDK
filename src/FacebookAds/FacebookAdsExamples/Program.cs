using System;
using System.Collections.Generic;

using Facebook;
using FacebookAds;
using FacebookAds.Object;
using FacebookAds.Object.Fields;

namespace FacebookAdsExamples
{
    class Program
    {
        /// <summary>
        /// The app is which is issued to you by Facebook
        /// This is usually public knowledge, altough I still don't reccomend throwing this out into the world without
        /// a good reason, but that's up to you
        /// </summary>
        const string APP_ID = "";

        /// <summary>
        /// The app secret which is issued to you by Facebook
        /// Keep this secret, seriously, don't let this get leaked out or your boss will probably fire you
        /// </summary>
        const string APP_SECRET = "";

        /// <summary>
        /// The access token used to identify the user with
        /// You'll have to obtain this manually or via the Facebook C# API (which the FacebookAds SDK uses)
        /// </summary>
        static string ACCESS_TOKEN = "";


        /// <summary>
        /// Main entry point of the application
        /// </summary>
        /// <param name="args">Arguments passed by the command line</param>
        static void Main(string[] args)
        {
            // Initialize the Facebook Ads SDK
            // You'll only have to do this once in your entire app as it's a singleton
            // If you ever want to change it, you can call Api.Destroy()
            Api.Initialize(APP_ID, APP_SECRET, ACCESS_TOKEN);

            // Check if the API has been initialized, just to be safe
            if (Api.IsInitialized == false) {
                throw new Exception("API was not initialized, something seriously went wrong");
            }

            // Let's make our first request! We can check if our access token is valid by simply calling the
            // 'me' route in the open graph API
            try {
                Api.Client.Get("me");
            } catch (FacebookOAuthException e) {
                Console.WriteLine("Unable to retrieve own account!");
                Console.WriteLine("Error: {0}", e.Message);
                Environment.Exit(-1);
            }

            // Awesome, that seemed to work!
            // Let's make a more complicated call, we're going to fetch a list of all insights from a campaign
            // For more information of how it works, the docs are your friend :)
            // See: https://developers.facebook.com/docs/marketing-api/insights-api/getting-started/v2.6
            try {

                // Change this to your campaign ID
                string id = "1234567890";

                // Get all insights from the given campaign between a time range
                var insights = (new Campaign(id)).GetInsights(new string[] {
                    InsightsFields.IMPRESSIONS,
                    InsightsFields.UNIQUE_CLICKS,
                    InsightsFields.REACH
                }, new Dictionary<string, object>() {
                    {
                        "time_range", new Dictionary<string, string>() {
                            {"since", "2016-01-01"},
                            {"until", "2016-05-11"}
                        }
                    }
                });

                // Loop over all of the insights
                Console.WriteLine("Successfully fetched campaign insights:");
                Console.WriteLine(insights);

            } catch (FacebookOAuthException e) {
                Console.WriteLine("Unable to retrieve campaign insights!");
                Console.WriteLine("Error: {0}", e.Message);
                Environment.Exit(-1);
            }
        }
    }
}
