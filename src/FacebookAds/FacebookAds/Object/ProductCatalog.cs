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
    public class ProductCatalog : AbstractCrudObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCatalog"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="parentId">The parent identifier.</param>
        /// <param name="client">The client.</param>
        public ProductCatalog(string id, string parentId = null, FacebookClient client = null) : base(id, parentId, client) { }

        /// <summary>Gets the endpoint of the API call.</summary>
        /// <returns>Endpoint URL</returns>
        protected override string GetEndpoint()
        {
            return "product_catalogs";
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
        /// Gets the check batch request status.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetCheckBatchRequestStatus(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("check_batch_request_status", fields, parameters);
        }

        /// <summary>
        /// Gets the destinations.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetDestinations(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("destinations", fields, parameters);
        }

        /// <summary>
        /// Gets the external event sources.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetExternalEventSources(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("external_event_sources", fields, parameters);
        }

        /// <summary>
        /// Gets the flights.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetFlights(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("flights", fields, parameters);
        }

        /// <summary>
        /// Gets the home listings.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetHomeListings(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("home_listings", fields, parameters);
        }

        /// <summary>
        /// Gets the hotel rooms batch.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetHotelRoomsBatch(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("hotel_rooms_batch", fields, parameters);
        }

        /// <summary>
        /// Gets the hotels.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetHotels(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("hotels", fields, parameters);
        }

        /// <summary>
        /// Gets the pricing variables batch.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetPricingVariablesBatch(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("pricing_variables_batch", fields, parameters);
        }

        /// <summary>
        /// Gets the product feeds.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetProductFeeds(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("product_feeds", fields, parameters);
        }

        /// <summary>
        /// Gets the product groups.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetProductGroups(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("product_groups", fields, parameters);
        }

        /// <summary>
        /// Gets the product sets.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetProductSets(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("product_sets", fields, parameters);
        }

        /// <summary>
        /// Gets the product sets batch.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetProductSetsBatch(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("product_sets_batch", fields, parameters);
        }

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>The result of <see cref="Facebook.FacebookClient"/>.Get()</returns>
        public object GetProducts(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("products", fields, parameters);
        }



    }
}


