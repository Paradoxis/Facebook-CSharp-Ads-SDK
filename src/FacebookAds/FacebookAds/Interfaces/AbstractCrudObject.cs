using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

using Facebook;

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
namespace FacebookAds.Interfaces
{
    /// <summary>
    /// Abstract create-remote-update-delete Object interface
    /// </summary>
    public abstract class AbstractCrudObject
    {
        /// <summary>
        /// The ID field identifier
        /// </summary>
        public const string FIELD_ID = "id";

        /// <summary>
        /// The FIELDS field identifier
        /// </summary>
        public const string FIELD_FIELDS = "fields";

        /// <summary>
        /// The identifier
        /// </summary>
        protected string id;

        /// <summary>
        /// The parent identifier
        /// </summary>
        protected string parentId;

        /// <summary>
        /// The data
        /// </summary>
        protected Dictionary<string, object> data = new Dictionary<string, object>();

        /// <summary>
        /// The client
        /// </summary>
        protected FacebookClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractCrudObject" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="parentId">The parent identifier.</param>
        /// <param name="client">The client.</param>
        /// <exception cref="FacebookApiException">An Api instance must be provided as argument or set as instance in [FacebookAds.Api]</exception>
        public AbstractCrudObject(string id, string parentId = null, FacebookClient client = null)
        {
            // Set the ID
            if (id != null) {
                this.id = id;
                data.Add(FIELD_ID, id);
            }

            // Set the parent ID
            if (parentId != null) {
                this.parentId = id;
            }

            // Check if the client is set
            if (client != null) {
                this.client = client;
            } else {
                if (Api.IsInitialized) {
                    this.client = Api.Client;
                } else {
                    throw new FacebookApiException("An Api instance must be provided as argument or set as instance in [FacebookAds.Api]");
                }
            }
        }

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <value>
        /// The client.
        /// </value>
        protected FacebookClient Client
        {
            get
            {
                return client;
            }
        }

        /// <summary>
        /// Assures the endpoint is valid.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <returns></returns>
        private string assureEndpoint(string endpoint = null)
        {
            // Check if endpoint is empty
            if (endpoint == null || endpoint == "") {
                endpoint = this.GetEndpoint();

                // Endpoint still empty?
                if (endpoint == null || endpoint == "") {
                    throw new FacebookApiException("Enpoint must be provided via a parameter or GetEndpoint()");
                } else {
                    return endpoint;
                }
            } else {
                return endpoint;
            }
        }

        /// <summary>
        /// Prepares the data.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        private Dictionary<string, object> assureData(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            if (fields != null) {
                data.Add(FIELD_FIELDS, String.Join(",", fields));
            } else {
                data.Add(FIELD_FIELDS, "");
            }

            if (parameters != null) {
                foreach (KeyValuePair<string, object> entry in parameters) {
                    data.Add(entry.Key, entry.Value);
                }
            }

            return data;
        }

        /// <summary>
        /// Gets many objects by connection without a specified endpoint
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        protected object getManyByConnection(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return Client.Get(this.assureEndpoint(), this.assureData(fields, parameters));
        }

        /// <summary>
        /// Gets many objects by connection.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// Result of Client.Get
        /// </returns>
        protected object getManyByConnection(string endpoint, string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return Client.Get(this.assureEndpoint(endpoint), this.assureData(fields, parameters));
        }

        /// <summary>
        /// Gets many objects by connection asynchronously.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>
        /// Result of Client.GetTaskAsync
        /// </returns>
        protected object getManyByConnectionAsync(string endpoint, string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return Client.GetTaskAsync(this.assureEndpoint(endpoint), this.assureData(fields, parameters));
        }

        /// <summary>
        /// Gets the endpoint of the API call.
        /// </summary>
        /// <returns>
        /// Endpoint URL
        /// </returns>
        protected abstract string GetEndpoint();
    }
}
