using Consume_REST_API.Models;
using Consume_REST_API.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Consume_REST_API.Services.Implementations
{
    public class RestApiConsumeServices : IRestApiConsumeServices
    {
        private readonly IConfiguration _configuration;
        public RestApiConsumeServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public dynamic ConsumeApi()
        {
            try
            {
                var response = GetImdbRating().Result;
                return response;
            }
            catch (Exception exception)
            {
                return exception;
            }
        }

        private async Task<dynamic> GetImdbRating()
        {
            try
            {
                string baseurl = _configuration.GetSection("imdb").GetSection("url").Value;
                string key = _configuration.GetSection("imdb").GetSection("key").Value;
                string endpointurl = baseurl + key + "/" + "tt0411008";
                HttpResponseMessage _resMsg;
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //string jsonBody = JsonConvert.SerializeObject(model);
                //var stringData = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                _resMsg = await client.GetAsync(endpointurl);
                var resReturnObj = _resMsg.Content.ReadAsAsync<ApiResponse>().Result;
                var serialized = JsonConvert.SerializeObject(resReturnObj);
                ApiResponse loginResponse = JsonConvert.DeserializeObject<ApiResponse>(serialized);
                return resReturnObj;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
