using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Facebook;
using FacebookAds.Interfaces;

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
/// <date>2016-02-16 10:04:16</date>
/// <author>Luke Paris (Paradoxis) | luke@paradoxis.nl</author>
///
/// <remarks>
/// This file was automatically generated using the Facebook Ads
/// PHP SDK to C# converter found in this library under '/src/SdkConverter/'
/// For more information please refer to the official documentation
/// </remarks>
namespace FacebookAds.Object.Values
{
    public class ReachFrequencyPredictionStatuses : AbstractCrudObjectFields
    {
        public const string SUCCESS = "1";
        public const string PENDING = "2";
        public const string UNREACHABLE_AUDIENCE = "3";
        public const string CONFIG_INVALID = "4";
        public const string TARGET_SPEC_INVALID = "5";
        public const string BUDGET_TOO_LOW = "6";
        public const string TOO_SHORT_AD_SET_LENGTH = "7";
        public const string TOO_LONG_AD_SET_LENGTH = "8";
        public const string END_DATE_TOO_FAR = "9";
        public const string FREQUENCY_CAP_NOT_SPECIFIED = "10";
        public const string UNSUPPORTED_PLACEMENT = "11";
        public const string DATE_ERROR = "12";
        public const string COUNTRY_NOT_SUPPORTED = "13";
        public const string BLACKOUT_DAYS = "14";
        public const string INSUFFICIENT_INVENTORY = "15";
        public const string REACH_BELOW_1_MILLION = "16";
        public const string MINIMUM_REACH_NOT_AVAILABLE = "17";
        public const string INVENTORY_CHANGED = "21";
        
    }
}


