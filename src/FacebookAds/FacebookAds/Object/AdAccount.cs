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
/// <date>2016-02-12 10:51:45</date>
/// <author>Luke Paris (Paradoxis) | luke@paradoxis.nl</author>
///
/// <remarks>
/// This file was automatically generated using the Facebook Ads
/// PHP SDK to C# converter found in this library under '/src/SdkConverter/'
/// For more information please refer to the official documentation
/// </remarks>
namespace FacebookAds.Object
{
    public class AdAccount : AbstractCrudObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdAccount"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="parentId">The parent identifier.</param>
        /// <param name="client">The client.</param>
        public AdAccount(string id, string parentId = null, FacebookClient client = null) : base(id, parentId, client) { }

        /// <summary>Gets the endpoint of the API call.</summary>
        /// <returns>Endpoint URL</returns>
        protected override string GetEndpoint()
        {
            return "adaccounts";
        }
        
        /// <summary>
        /// Gets the activities.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetActivities(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("activities", fields, parameters);
        }
                
        /// <summary>
        /// Gets the ad users.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdUsers(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(AdUser), fields, parameters);
        }
                
        /// <summary>
        /// Gets the campaigns.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetCampaigns(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(Campaign), fields, parameters);
        }
                
        /// <summary>
        /// Gets the ad sets.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdSets(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(AdSet), fields, parameters);
        }
                
        /// <summary>
        /// Gets the ads.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAds(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(Ad), fields, parameters);
        }
                
        /// <summary>
        /// Gets the ad creatives.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdCreatives(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(AdCreative), fields, parameters);
        }
                
        /// <summary>
        /// Gets the ad images.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdImages(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(AdImage), fields, parameters);
        }
                
        /// <summary>
        /// Gets the ads pixels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdsPixels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(AdsPixel), fields, parameters);
        }
                
        /// <summary>
        /// Gets the ad videos.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdVideos(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(AdVideo), fields, parameters);
        }
                
        /// <summary>
        /// Gets the broad category targeting.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetBroadCategoryTargeting(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("broadtargetingcategories", fields, parameters);
        }
                
        /// <summary>
        /// Gets the connection objects.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetConnectionObjects(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("connectionobjects", fields, parameters);
        }
                
        /// <summary>
        /// Gets the custom audiences.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetCustomAudiences(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(CustomAudience), fields, parameters);
        }
                
        /// <summary>
        /// Gets the conversion pixels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetConversionPixels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(AdConversionPixel), fields, parameters);
        }
                
        /// <summary>
        /// Gets the partner categories.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetPartnerCategories(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(PartnerCategory), fields, parameters);
        }
                
        /// <summary>
        /// Gets the rate cards.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetRateCards(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("ratecard", fields, parameters);
        }
                
        /// <summary>
        /// Gets the reach estimate.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetReachEstimate(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("reachestimate", fields, parameters);
        }
                
        /// <summary>
        /// Gets the reach frequency predictions.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetReachFrequencyPredictions(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(ReachFrequencyPrediction), fields, parameters);
        }
                
        /// <summary>
        /// Gets the targeting description.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetTargetingDescription(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("targetingsentencelines", fields, parameters);
        }
                
        /// <summary>
        /// Gets the transactions.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetTransactions(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("transactions", fields, parameters);
        }
                
        /// <summary>
        /// Gets the ad previews.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdPreviews(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("generatepreviews", fields, parameters);
        }
                
        /// <summary>
        /// Gets the insights.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetInsights(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("insights", fields, parameters);
        }
                
        /// <summary>
        /// Gets the insights asynchronously.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetInsightsAsync(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnectionAsync(typeof(AsyncJobInsights), fields, parameters);
        }
                
        /// <summary>
        /// Gets the agencies.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAgencies(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("agencies", fields, parameters);
        }
                
        /// <summary>
        /// Gets the minimum budgets.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetMinimumBudgets(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("minimum_budgets", fields, parameters);
        }
                
        /// <summary>
        /// Gets the ad place page sets.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdPlacePageSets(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(AdPlacePageSet), fields, parameters);
        }
                
        /// <summary>
        /// Gets the ad labels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdLabels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(AdLabel), fields, parameters);
        }
                
        /// <summary>
        /// Gets the campaigns by label.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetCampaignsByLabel(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("campaignsbylabels", fields, parameters);
        }
                
        /// <summary>
        /// Gets the ad sets by label.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdSetsByLabel(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adsetsbylabels", fields, parameters);
        }
                
        /// <summary>
        /// Gets the ads by label.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdsByLabel(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adsbylabels", fields, parameters);
        }
                
        /// <summary>
        /// Gets the ad creatives by label.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdCreativesByLabel(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adcreativesbylabels", fields, parameters);
        }
                
        /// <summary>
        /// Gets the custom conversions.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetCustomConversions(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(CustomConversion), fields, parameters);
        }
                
    }
}


