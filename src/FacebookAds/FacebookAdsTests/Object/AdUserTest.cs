using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FacebookAds.Object;

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
    public class AdUserTest
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private string id;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdUserTest"/> class.
        /// </summary>
        public AdUserTest()
        {
            // TODO: get user ID's dynamically here
            this.id = "me";
        }

        /// <summary>
        /// Tests the ad user GetBusinesses method.
        /// </summary>
        [TestMethod]
        public void AdUserGetBusinessesTest()
        {
            Console.WriteLine("Initializing [FacebookAds.Object.AdUser]");
            AdUser user = new AdUser(id);

            Console.WriteLine("Calling [FacebookAds.Object.AdUser].GetAdAccounts()");
            //Console.WriteLine("Result: {0}", user.GetBusinesses());
        }

        /// <summary>
        /// Tests the GetAdAccounts method
        /// </summary>
        [TestMethod]
        public void AdUserGetAdAccountsTest()
        {
            Console.WriteLine("Initializing [FacebookAds.Object.AdUser]");
            AdUser user = new AdUser(id);

            Console.WriteLine("Calling [FacebookAds.Object.AdUser].GetAdAccounts()");
            Console.WriteLine("Result: {0}", user.GetAdAccounts());
        }

        /// <summary>
        /// Ads the user get ad account groups test.
        /// </summary>
        [TestMethod]
        public void AdUserGetAdAccountGroupsTest()
        {
            Console.WriteLine("Initializing [FacebookAds.Object.AdUser]");
            AdUser user = new AdUser(id);

            Console.WriteLine("Calling [FacebookAds.Object.AdUser].GetAdAccountGroups()");
            Console.WriteLine("Result: {0}", user.GetAdAccountGroups());
        }
    }
}
