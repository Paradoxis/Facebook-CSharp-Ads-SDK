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
    public class Business : AbstractCrudObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Business"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="parentId">The parent identifier.</param>
        /// <param name="client">The client.</param>
        public Business(string id, string parentId = null, FacebookClient client = null) : base(id, parentId, client) { }

        /// <summary>Gets the endpoint of the API call.</summary>
        /// <returns>Endpoint URL</returns>
        protected override string GetEndpoint()
        {
            return "";
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
        /// Gets the client ad accounts.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetClientAdAccounts(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("client_ad_accounts", fields, parameters);
        }

        /// <summary>
        /// Gets the client pages.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetClientPages(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("client_pages", fields, parameters);
        }

        /// <summary>
        /// Gets the event source groups.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetEventSourceGroups(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("event_source_groups", fields, parameters);
        }

        /// <summary>
        /// Gets the grp plans.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetGrpPlans(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("grp_plans", fields, parameters);
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
        /// Gets the measurement reports.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetMeasurementReports(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("measurement_reports", fields, parameters);
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
        /// Gets the owned ad accounts.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetOwnedAdAccounts(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("owned_ad_accounts", fields, parameters);
        }

        /// <summary>
        /// Gets the owned instagram accounts.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetOwnedInstagramAccounts(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("owned_instagram_accounts", fields, parameters);
        }

        /// <summary>
        /// Gets the owned pages.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetOwnedPages(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("owned_pages", fields, parameters);
        }

        /// <summary>
        /// Gets the owned pixels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetOwnedPixels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("owned_pixels", fields, parameters);
        }

        /// <summary>
        /// Gets the pending client ad accounts.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetPendingClientAdAccounts(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("pending_client_ad_accounts", fields, parameters);
        }

        /// <summary>
        /// Gets the pending owned ad accounts.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetPendingOwnedAdAccounts(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("pending_owned_ad_accounts", fields, parameters);
        }

        /// <summary>
        /// Gets the picture.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetPicture(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("picture", fields, parameters);
        }

        /// <summary>
        /// Gets the received audience permissions.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetReceivedAudiencePermissions(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("received_audience_permissions", fields, parameters);
        }

        /// <summary>
        /// Gets the shared audience permissions.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetSharedAudiencePermissions(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("shared_audience_permissions", fields, parameters);
        }



    }
}


