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
/// Copyright (c) 2017 - Luke Paris (Paradoxis) | Searchresult Performancemarketing
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
/// <date>2017-11-12 14:56:48</date>
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
        /// Gets the ad place page sets.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdPlacePageSets(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("ad_place_page_sets", fields, parameters);
        }

        /// <summary>
        /// Gets the ad asset feeds.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdAssetFeeds(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adasset_feeds", fields, parameters);
        }

        /// <summary>
        /// Gets the ad creatives.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdCreatives(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adcreatives", fields, parameters);
        }

        /// <summary>
        /// Gets the ad creatives by labels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdCreativesByLabels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adcreativesbylabels", fields, parameters);
        }

        /// <summary>
        /// Gets the ad images.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdImages(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adimages", fields, parameters);
        }

        /// <summary>
        /// Gets the ad labels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdLabels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adlabels", fields, parameters);
        }

        /// <summary>
        /// Gets the ad report runs.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdReportRuns(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adreportruns", fields, parameters);
        }

        /// <summary>
        /// Gets the ad report schedules.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdReportSchedules(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adreportschedules", fields, parameters);
        }

        /// <summary>
        /// Gets the ad rules history.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdRulesHistory(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adrules_history", fields, parameters);
        }

        /// <summary>
        /// Gets the ads.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAds(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("ads", fields, parameters);
        }

        /// <summary>
        /// Gets the ads by labels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdsByLabels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adsbylabels", fields, parameters);
        }

        /// <summary>
        /// Gets the ad sets.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdSets(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adsets", fields, parameters);
        }

        /// <summary>
        /// Gets the ad sets by labels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdSetsByLabels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adsetsbylabels", fields, parameters);
        }

        /// <summary>
        /// Gets the ads pixels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdsPixels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adspixels", fields, parameters);
        }

        /// <summary>
        /// Gets the advertisable applications.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdvertisableApplications(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("advertisable_applications", fields, parameters);
        }

        /// <summary>
        /// Gets the ad videos.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdVideos(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("advideos", fields, parameters);
        }

        /// <summary>
        /// Gets the applications.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetApplications(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("applications", fields, parameters);
        }

        /// <summary>
        /// Gets the asynchronously ad request sets.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAsyncAdRequestSets(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnectionAsync("asyncadrequestsets", fields, parameters);
        }

        /// <summary>
        /// Gets the broad targeting categories.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetBroadTargetingCategories(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("broadtargetingcategories", fields, parameters);
        }

        /// <summary>
        /// Gets the campaigns.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetCampaigns(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("campaigns", fields, parameters);
        }

        /// <summary>
        /// Gets the campaigns by labels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetCampaignsByLabels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("campaignsbylabels", fields, parameters);
        }

        /// <summary>
        /// Gets the custom audiences.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetCustomAudiences(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("customaudiences", fields, parameters);
        }

        /// <summary>
        /// Gets the custom audiences tos.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetCustomAudiencesTos(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("customaudiencestos", fields, parameters);
        }

        /// <summary>
        /// Gets the delivery estimate.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetDeliveryEstimate(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("delivery_estimate", fields, parameters);
        }

        /// <summary>
        /// Gets the generate previews.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetGeneratePreviews(string[] fields = null, Dictionary<string, object> parameters = null)
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
            return this.getManyByConnectionAsync("insights", fields, parameters);
        }

        /// <summary>
        /// Gets the instagram accounts.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetInstagramAccounts(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("instagram_accounts", fields, parameters);
        }

        /// <summary>
        /// Gets the lead gen forms.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetLeadGenForms(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("leadgen_forms", fields, parameters);
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
        /// Gets the offline conversion data sets.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetOfflineConversionDataSets(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("offline_conversion_data_sets", fields, parameters);
        }

        /// <summary>
        /// Gets the offsite pixels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetOffsitePixels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("offsitepixels", fields, parameters);
        }

        /// <summary>
        /// Gets the partner categories.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetPartnerCategories(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("partnercategories", fields, parameters);
        }

        /// <summary>
        /// Gets the partners.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetPartners(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("partners", fields, parameters);
        }

        /// <summary>
        /// Gets the publisher block lists.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetPublisherBlockLists(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("publisher_block_lists", fields, parameters);
        }

        /// <summary>
        /// Gets the rate card.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetRateCard(string[] fields = null, Dictionary<string, object> parameters = null)
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
            return this.getManyByConnection("reachfrequencypredictions", fields, parameters);
        }

        /// <summary>
        /// Gets the roas.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetRoas(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("roas", fields, parameters);
        }

        /// <summary>
        /// Gets the targeting browse.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetTargetingBrowse(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("targetingbrowse", fields, parameters);
        }

        /// <summary>
        /// Gets the targeting search.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetTargetingSearch(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("targetingsearch", fields, parameters);
        }

        /// <summary>
        /// Gets the targeting sentence lines.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetTargetingSentenceLines(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("targetingsentencelines", fields, parameters);
        }

        /// <summary>
        /// Gets the targeting suggestions.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetTargetingSuggestions(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("targetingsuggestions", fields, parameters);
        }

        /// <summary>
        /// Gets the targeting validation.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetTargetingValidation(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("targetingvalidation", fields, parameters);
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
        /// Gets the users.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetUsers(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("users", fields, parameters);
        }



    }
}


