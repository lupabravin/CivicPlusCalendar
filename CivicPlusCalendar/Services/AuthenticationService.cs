using CivicPlusCalendar.Constants;
using CivicPlusCalendar.Models.DTO;
using CivicPlusCalendar.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CivicPlusCalendar.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IConfiguration _configuration;
        private string _clientId, _clientSecret, _requestPrefix, _baseUri;

        #region Constructors
        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
            _clientId = _configuration.GetValue<string>("ClientId");
            _clientSecret = _configuration.GetValue<string>("ClientSecret");

            _baseUri = _configuration.GetValue<string>("Host");
            _requestPrefix = _configuration.GetValue<string>("RequestPrefix");
        }

        //Test Constructor
        public AuthenticationService(string clientId, string clientSecret, string baseUri, string requestPrefix)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;

            _baseUri = baseUri;
            _requestPrefix = requestPrefix;
        }
        #endregion

        #region Methods
        public async Task<string> GetToken()
        {
            string token = null;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUri);
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var authDTO = new AuthenticationDTO
            {
                ClientId = _clientId,
                ClientSecret = _clientSecret
            };

            var jsonContent = JsonConvert.SerializeObject(authDTO);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var route = _requestPrefix + Routes.AUTH;

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, route);
            request.Content = httpContent;
            
            await client.SendAsync(request)
                .ContinueWith(responseTask =>
                {
                    var responseMesssage = responseTask.Result.Content.ReadAsStringAsync().Result;
                    token = JObject.Parse(responseMesssage)["access_token"].ToString();
                });

            return token;
        }
        #endregion
    }
}
