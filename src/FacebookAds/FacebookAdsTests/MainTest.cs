using Microsoft.VisualStudio.TestTools.UnitTesting;

using Searchresult.FacebookAds;
using System;

namespace Searchresult.FacebookAdsTests
{
    [TestClass]
    public class MainTest
    {
        [AssemblyInitialize]
        public static void main(TestContext context) {}


        [TestMethod]
        public void TestApi()
        {
            Api.init("test", "test", "test");
        }
    }
}
