using Newtonsoft.Json;
using Prototype2.Services.Interfaces;
using Prototype2Shared.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Prototype2.Services
{
    public class AuthenticationServices : IAuthentication
    {
        private HttpClient _httpClient;
        private IAppConfiguration _config;

        public AuthenticationServices(IAppConfiguration config, IHttpNativeHandler handler)
        {
            _httpClient = new HttpClient(handler.GetHttpClientHandler());
            _config = config;
        }

        public async Task<bool> Authenticate(string userName, string pin)
        {
            Uri uri = new Uri(_config.BankingServerUrl + "api/Authentication");

            try
            {
                var request = new AuthRequest() { UserName = userName, Pin = pin };
                string requestJson = JsonConvert.SerializeObject(request);

                StringContent content = new StringContent(requestJson, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await _httpClient.PostAsync(uri, content);


                if (response.IsSuccessStatusCode)
                {
                    var contentResponse = await response.Content.ReadAsStringAsync();

                    var valueResponse = JsonConvert.DeserializeObject<bool>(contentResponse);

                    return valueResponse;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return false;
        }
    }
}
