using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using OfflineCapable.Models;

namespace OfflineCapable.Data
{
    public class DataverseContext
    {
        #region connection info

        private static string serviceClientUrl = ConfigurationSettings.serviceClientUrl;
        private string clientId = ConfigurationSettings.clientId;
        private string clientSecret = ConfigurationSettings.clientSecret;
        private string loginUrl = ConfigurationSettings.loginUrl;

        private AuthenticationResult authenticationResult = null;
        #endregion


        public DataverseContext()
        {
            this.GetAuthorization();
        }

        public void GetAuthorization()
        {
            AuthenticationContext authContext = new AuthenticationContext(loginUrl);
            ClientCredential creds = new ClientCredential(clientId, clientSecret);

            authenticationResult = authContext.AcquireTokenAsync(serviceClientUrl, creds).Result;
        }

        public async Task<HttpResponseMessage> GetInspections()
        {
            var client = new HttpClient
            {
                // See https://docs.microsoft.com/en-us/powerapps/developer/data-platform/webapi/compose-http-requests-handle-errors#web-api-url-and-versions
                BaseAddress = new Uri(serviceClientUrl + "/api/data/v9.2/"),
                Timeout = new TimeSpan(0, 2, 0)    // Standard two minute timeout on web service calls.
            };

            // Default headers for each Web API call.
            // See https://docs.microsoft.com/powerapps/developer/data-platform/webapi/compose-http-requests-handle-errors#http-headers
            HttpRequestHeaders headers = client.DefaultRequestHeaders;
            headers.Authorization = new AuthenticationHeaderValue("Bearer", authenticationResult.AccessToken);
            headers.Add("OData-MaxVersion", "4.0");
            headers.Add("OData-Version", "4.0");
            headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client.GetAsync("bac_inspections").Result;
        }
    }
}
