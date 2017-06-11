using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
namespace FacebookAds
{
    /// <summary>
    /// Api class initializer
    /// </summary>
    public class Api
    {
        /// <summary>
        /// The version of the graph API we're using
        /// </summary>
        public const string VERSION = "v2.9";

        /// <summary>
        /// The client
        /// </summary>
        protected static FacebookClient client = null;

        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        /// <value>
        /// The client.
        /// </value>
        public static FacebookClient Client
        {
            get
            {
                return Api.client;
            }

            set
            {
                Api.client = value;
            }
        }

        /// <summary>
        /// Initializes the application via pre-initialized clients
        /// </summary>
        /// <param name="client">The client.</param>
        public static void Initialize(FacebookClient client)
        {
            Api.client = client;
        }

        /// <summary>
        /// Initializes the application via tokens
        /// </summary>
        /// <param name="appId">The application identifier.</param>
        /// <param name="appSecret">The application secret.</param>
        /// <param name="accessToken">The access token.</param>
        public static void Initialize(string appId, string appSecret, string accessToken)
        {
            Api.client = new FacebookClient();
            Api.client.AppId = appId;
            Api.client.AppSecret = appSecret;
            Api.client.AccessToken = accessToken;
            Api.client.Version = Api.VERSION;
        }

        /// <summary>
        /// Destroys the client object and resets the API
        /// Might as well just re-initialize the object instead, but added for consistency.
        /// </summary>
        public static void Destroy()
        {
            Api.client = null;
        }

        /// <summary>
        /// Checks if the class is initialized
        /// </summary>
        public static bool IsInitialized
        {
            get
            {
                return (Api.client != null);
            }
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="Api"/> class from being created.
        /// </summary>
        private Api() { }
    }
}
