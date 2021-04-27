using CivicPlusCalendar.Constants;
using CivicPlusCalendar.Models;
using CivicPlusCalendar.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CivicPlusCalendar.Services
{
    public class EventService : IEventService
    {
        IConfiguration _configuration;
        IAuthenticationService _authenticationService;
        private string _token, _baseUri, _requestPrefix;

        #region Constructors
        public EventService(IConfiguration configuration, IAuthenticationService authenticationService)
        {
            _configuration = configuration;
            _authenticationService = authenticationService;
            _token = authenticationService.GetToken().Result;
            _baseUri = _configuration.GetValue<string>("Host");
            _requestPrefix = _configuration.GetValue<string>("RequestPrefix");
        }
        #endregion

        #region Methods
        public async Task<List<EventViewModel>> GetEvents()
        {
            var eventList = new List<EventViewModel>();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUri);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");
       
            var route = _requestPrefix + Routes.EVENTS;
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, route);

            await client.SendAsync(request)
                .ContinueWith(responseTask =>
                {
                    var responseMesssage = responseTask.Result.Content.ReadAsStringAsync().Result;
                    var message = JObject.Parse(responseMesssage);
                    var total = message["total"].ToString();
                    var items = message["items"].ToString();
                    eventList = JsonConvert.DeserializeObject<List<EventViewModel>>(items);
                });


            return eventList;
        }

        public async Task<EventViewModel> PostEvent(EventViewModel eventModel)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUri);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");


            var jsonContent = JsonConvert.SerializeObject(eventModel);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var route = _requestPrefix + Routes.EVENTS;

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, route);
            request.Content = httpContent;
            var response = new JObject();
            await client.SendAsync(request)
                .ContinueWith(responseTask =>
                {
                    var responseMesssage = responseTask.Result.Content.ReadAsStringAsync().Result;
                    response = JObject.Parse(responseMesssage);
                });

            return eventModel;
        }
        #endregion
    }
}
