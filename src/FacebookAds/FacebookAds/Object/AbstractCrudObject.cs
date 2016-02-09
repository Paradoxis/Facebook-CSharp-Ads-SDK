using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Searchresult.FacebookAds.Object
{
    abstract class AbstractCrudObject
    {
        /// <summary>
        /// The API
        /// </summary>
        protected Api api;

        /// <summary>
        /// Assures the API.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>
        /// Fully validated instance of Api
        /// </returns>
        /// <exception cref="System.NullReferenceException">An Api instance must be provided as argument or set as instance in Searchresult.FacebookAds.Api</exception>
        protected static Api assureApi(Api instance = null)
        {
            instance = (instance != null) ? instance : Api.Instance;

            if (instance == null) {
                throw new NullReferenceException("An Api instance must be provided as argument or set as instance in Searchresult.FacebookAds.Api");
            } else {
                return instance;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractCrudObject" /> class.
        /// </summary>
        /// <param name="api">The API instance.</param>
        public AbstractCrudObject(Api api = null)
        {
            this.api = assureApi(api);
        }

        /// <summary>
        /// Gets or sets the API instance.
        /// </summary>
        /// <value>
        /// The API instance.
        /// </value>
        public Api Api
        {
            get
            {
                return this.api;
            }

            set
            {
                this.api = value;
            }
        }

        /// <summary>
        /// The data retrieved from an API call
        /// </summary>
        protected dynamic data;

        /// <summary>
        /// Sets the data without validation.
        /// </summary>
        /// <param name="data">The data.</param>
        protected void setDataWithoutValidation(dynamic data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets the node path.
        /// </summary>
        /// <value>
        /// The node path.
        /// </value>
        protected string NodePath
        {
            get
            {
                return "";
            }
        }

        abstract protected string Endpoint;

        /// <summary>
        /// Creates the specified parameters.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public AbstractCrudObject create(NameValueCollection parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads the specified fields.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public AbstractCrudObject read(string[] fields, NameValueCollection parameters)
        {
            string _fields = String.Join(",", fields);

            if (_fields != null && _fields != "") {
                parameters.Add("fields", _fields);
            }

            this.setDataWithoutValidation(this.Api.Client.Get(this.NodePath, parameters));

            return this;
        }

        /// <summary>
        /// Updates the specified parameters.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public AbstractCrudObject update(NameValueCollection parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified parameters.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public AbstractCrudObject delete(NameValueCollection parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the specified parameters.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public AbstractCrudObject save(NameValueCollection parameters)
        {
            throw new NotImplementedException();
        }
    }
}
