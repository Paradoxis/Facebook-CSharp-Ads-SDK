using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Facebook;
using FacebookAds;
using FacebookAds.Object;
using FacebookAdsTests.Properties;

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
namespace FacebookAdsTests
{
    /// <summary>
    /// Unit test class to test the campagin functionality
    /// </summary>
    [TestClass]
    public class ApiTest
    {
        /// <summary>
        /// Tests the ad user class.
        /// </summary>
        [TestMethod]
        public void TestAdUser()
        {
            Console.WriteLine("Initializing [FacebookAds.Object.AdUser]");
            AdUser user = new AdUser("me");

            Console.WriteLine("Calling [FacebookAds.Object.AdUser].GetAdAccounts()");
            var result = user.GetAdAccounts();
            Console.Write("Result: ");
            Console.WriteLine(result);
        }

        /// <summary>
        /// Tests the campaign class.
        /// </summary>
        [TestMethod]
        public void TestCampagin()
        {
            Console.WriteLine("Initializing [FacebookAds.Object.Campaign]");
            Campaign campaign = new Campaign("");

            try {
                Console.WriteLine("Calling [FacebookAds.Object.Campaign].GetAdSets()");
                var result = campaign.GetAdSets();
                Console.WriteLine("Result: {0}", result);
            } catch(FacebookOAuthException e) {
                Console.WriteLine("Caught OAuth Exception: {0}", e.Message);
            }
        }
    }
}
