using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Facebook;
using FacebookAds.Object;
using FacebookAds.Object.Fields;
using FacebookAds;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

/// <summary>
/// The MIT License (MIT)
///
/// Copyright (c) 2016 - Luke Paris (Paradoxis) | Searchresult Performancemarketing
///
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.
/// </summary>
namespace FacebookAdsTests.Object
{
    [TestClass]
    public class CampaignTest
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private string id;

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignTest"/> class.
        /// </summary>
        public CampaignTest()
        {
            // TODO: get campaign ID's dynamically here
            this.id = "6036856717278";
        }

        /// <summary>
        /// Tests the campaign class.
        /// </summary>
        [TestMethod]
        public void CampaignGetAdSetsTest()
        {
            Console.WriteLine("Initializing [FacebookAds.Object.Campaign]");
            Campaign campaign = new Campaign(id);

            Console.WriteLine("Calling [FacebookAds.Object.Campaign].GetAdSets()");
            Console.WriteLine("Result: {0}", campaign.GetAdSets());
        }

        /// <summary>
        /// Tests the campaign class.
        /// </summary>
        [TestMethod]
        public void CampaignGetAdsTest()
        {
            Console.WriteLine("Initializing [FacebookAds.Object.Campaign]");
            Campaign campaign = new Campaign(id);

            Console.WriteLine("Calling [FacebookAds.Object.Campaign].GetAds()");
            Console.WriteLine("Result: {0}", campaign.GetAds());
        }

        /// <summary>
        /// Tests the campaign class.
        /// </summary>
        [TestMethod]
        public void CampaignGetInsightsTest()
        {
            var output = (new Campaign(id)).GetInsights(new string[] {
                InsightsFields.IMPRESSIONS,
                InsightsFields.UNIQUE_CLICKS,
                InsightsFields.REACH
            }, new Dictionary<string, object>() {
                {
                    "time_range", new Dictionary<string, string>() {
                        {"since", "2016-02-09"},
                        {"until", "2016-02-16"}
                    }
                }
            });


            Debug.WriteLine(output);
        }

        /// <summary>
        /// Tests the campaign class.
        /// </summary>
        [TestMethod]
        public void CampaignGetInsightsAsyncTest()
        {
            Console.WriteLine("Initializing [FacebookAds.Object.Campaign]");
            Campaign campaign = new Campaign(id);

            Console.WriteLine("Calling [FacebookAds.Object.Campaign].GetInsightsAsync()");
            Console.WriteLine("Result: {0}", campaign.GetInsightsAsync());
        }
    }
}
;