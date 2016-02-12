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
    public class Business : AbstractCrudObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdAccount"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="parentId">The parent identifier.</param>
        /// <param name="client">The client.</param>
        public Business(string id, string parentId = null, FacebookClient client = null) : base(id, parentId, client) { }

        /// <summary>Gets the endpoint of the API call.</summary>
        /// <returns>Endpoint URL</returns>
        protected override string GetEndpoint()
        {
            return "businesses";
        }
        
        /// <summary>
        /// Gets the ad accounts.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetAdAccounts(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adaccounts", fields, parameters);
        }
                
        /// <summary>
        /// Gets the user permissions.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetUserPermissions(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("userpermissions", fields, parameters);
        }
                
        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetProjects(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(Project), fields, parameters);
        }
                
        /// <summary>
        /// Gets the pages.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetPages(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(Page), fields, parameters);
        }
                
        /// <summary>
        /// Gets the apps.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetApps(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("apps", fields, parameters);
        }
                
        /// <summary>
        /// Gets the clients.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetClients(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("clients", fields, parameters);
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
        /// Gets the credit cards.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetCreditCards(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("creditcards", fields, parameters);
        }
                
        /// <summary>
        /// Gets the extended credits.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetExtendedCredits(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("extendedcredits", fields, parameters);
        }
                
        /// <summary>
        /// Gets the product catalogues.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetProductCatalogues(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("product_catalogs", fields, parameters);
        }
                
        /// <summary>
        /// Gets the system users.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetSystemUsers(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection(typeof(SystemUser), fields, parameters);
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
                
    }
}


