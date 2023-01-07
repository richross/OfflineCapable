using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Configuration;
//using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using OfflineCapable.Models.PwrPlt;

namespace OfflineCapable.Data
{
    public class DataverseContext
    {
        #region connection info

        private static string serviceClientUrl;
        private string clientId;
        private string clientSecret;
        private string loginUrl;

        private AuthenticationResult authenticationResult = null;
        #endregion

        public DataverseContext(IConfiguration config)
        {
            serviceClientUrl = config["serviceClientUrl"];
            clientId = config["clientId"];
            clientSecret = config["clientSecret"];
            loginUrl = config["loginUrl"];

            this.GetAuthorization();
        }

        public void GetAuthorization()
        {
            AuthenticationContext authContext = new AuthenticationContext(loginUrl);
            ClientCredential creds = new ClientCredential(clientId, clientSecret);

            authenticationResult = authContext.AcquireTokenAsync(serviceClientUrl, creds).Result;
        }

        public async Task<InspectionsPwrPlt> GetInspections()
        {
            string DataVerseTableName = "cr71b_inspections";

            HttpResponseMessage response = await CallDataVerseAPI(DataVerseTableName);

            return await response.Content.ReadFromJsonAsync<InspectionsPwrPlt>();
        }

        public async Task<BusinessesPwrPlt> GetBusinesses()
        {
            string DataVerseTableName = "cr71b_businesses";

            HttpResponseMessage response = await CallDataVerseAPI(DataVerseTableName);

            return await response.Content.ReadFromJsonAsync<BusinessesPwrPlt>();
        }

        private async Task<HttpResponseMessage> CallDataVerseAPI(string dataVerseTableName)
        {
            //create the item to return
            HttpResponseMessage response = null;


            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(serviceClientUrl + "/api/data/v9.2/");
                    client.Timeout = new TimeSpan(0, 2, 0);   // Standard two minute timeout on web service calls.

                    // Default headers for each Web API call.
                    // See https://docs.microsoft.com/powerapps/developer/data-platform/webapi/compose-http-requests-handle-errors#http-headers
                    HttpRequestHeaders headers = client.DefaultRequestHeaders;
                    headers.Authorization = new AuthenticationHeaderValue("Bearer", authenticationResult.AccessToken);
                    headers.Add("OData-MaxVersion", "4.0");
                    headers.Add("OData-Version", "4.0");
                    headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    response = client.GetAsync(dataVerseTableName).Result;
                }
            }
            catch (Exception ex)
            {
                //log error and prompt notification
                return response;
            }

            return response;
        }
    }
}