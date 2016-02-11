using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FacebookAds.Interfaces;

namespace FacebookAds.Object
{
    /// <summary>
    /// Allows for Business functionality via simple to use methods
    /// </summary>
    /// <seealso cref="FacebookAds.Interfaces.AbstractCrudObject" />
    class Business : AbstractCrudObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Business"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public Business(string id) : base(id) { }

        /// <summary>
        /// Gets the endpoint of the API call.
        /// </summary>
        /// <returns>
        /// Endpoint URL
        /// </returns>
        protected override string GetEndpoint()
        {
            return "businesses";
        }

        /// <summary>
        /// Gets the ad accounts.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public object getAdAccounts(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("adaccounts", fields, parameters);
        }

        /// <summary>
        /// Gets the user permissions.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public object getUserPermissions(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("userpermissions", fields, parameters);
        }

        /// <summary>
        /// Gets the apps.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public object GetApps(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("apps", fields, parameters);
        }

        /// <summary>
        /// Gets the clients.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public object GetClients(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("clients", fields, parameters);
        }

        /// <summary>
        /// Gets the agencies.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public object GetAgencies(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("agencies", fields, parameters);
        }

        /// <summary>
        /// Gets the credit cards.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public object GetCreditCards(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("creditcards", fields, parameters);
        }

        /// <summary>
        /// Gets the extended credits.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public object GetExtendedCredits(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("extendedcredits", fields, parameters);
        }

        /// <summary>
        /// Gets the product catalogues.
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public object GetProductCatalogues(string[] fields = null, Dictionary<string, object> parameters = null)
        {
            return this.getManyByConnection("product_catalogs", fields, parameters);
        }
    }
}
