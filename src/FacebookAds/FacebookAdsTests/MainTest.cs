using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Facebook;
using FacebookAds;
using FacebookAds.Properties;

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
    /// Unit testing class to test the functionality of the main features of the library
    /// </summary>
    [TestClass]
    public class MainTest
    {
        /// <summary>
        /// Mains the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        [AssemblyInitialize]
        public static void main(TestContext context)
        {
            Console.WriteLine("Starting unit test at {0}", DateTime.Now);
            Console.WriteLine("Initializing [FacebookAds.Api]");
            Api.Initialize(Settings.Default.AppId, Settings.Default.AppSecret, Settings.Default.AccessToken);
            Console.WriteLine("-----------------------------------------------");
        }

        /// <summary>
        /// Tests the API.
        /// </summary>
        [TestMethod]
        public void TestApi()
        {
            Console.WriteLine("Current [FacebookAds.Api].IsInitialized value: {0}", Api.IsInitialized);
            Console.WriteLine("Calling [FacebookAds.Api].Destroy()");
            Api.Destroy();
            Console.WriteLine("Destroyed [FacebookAds.Api] with result: {0}", Api.IsInitialized);
        }

        [TestMethod]
        public void TestFacebookConnectivity()
        {
            Console.WriteLine("Calling [Facebook.FacebookClient].Get()");
            var result = Api.Client.Get("me");
            Console.Write("Result: ");
            Console.WriteLine(result);
        }
    }
}
