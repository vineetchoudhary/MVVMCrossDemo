/*
 * 
 * Created By Vineet Choudhary
 * Nuget Dependencies - Newtonsoft.Json & System.Net.Http
 * 
 */

using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Common.Services;
using Newtonsoft.Json;

namespace Common.RestClient
{

    public class RestClient
    {
        //Private Fields
        private HttpClient _httpClient = new HttpClient();

        //Public Properties
        public string AcceptContentType { get; set; }
        public string RequestContentType { get; set; }
        public RequestState CurrentRequestState { get; private set; } = RequestState.Initialize;

        public static RestClient Default => new RestClient();

        //Constructors
        public RestClient()
        {
            AcceptContentType = ContentType.JSON;
            RequestContentType = ContentType.JSON;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(AcceptContentType));
        }

        //Request Methods
        public async Task<TResult> Request<TResult>(string url, HttpMethod method, object data = null) where TResult : class
        {
            var logString = $"{method} - {url}\n";
            CurrentRequestState = RequestState.Ongoing;
            HttpResponseMessage response = null;

            try
            {
                HttpRequestMessage request = new HttpRequestMessage(method, url);
                if (data != null)
                {
                    var postContent = JsonConvert.SerializeObject(data);
                    logString += $"Request Content - ${postContent}\n";
                    request.Content = new StringContent(postContent);
                    request.Content.Headers.ContentType = new MediaTypeHeaderValue(RequestContentType);
                }
                response = await _httpClient.SendAsync(request);
            }
            catch (Exception ex)
            {
                logString += $"Rest Client Exception - {ex.Message}\nStackTrace - {ex.StackTrace}";
            }

            if (response?.IsSuccessStatusCode ?? false)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                if (!String.IsNullOrEmpty(responseString))
                {
                    var result = JsonConvert.DeserializeObject<TResult>(responseString);
                    return result;
                }

                DLog.Success($"{logString}Response Data - {responseString}");
                CurrentRequestState = RequestState.Success;
                return default(TResult);
            }

            DLog.Error($"{logString}Status Code - {response?.StatusCode}");
            CurrentRequestState = RequestState.Failed;
            return default(TResult);
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
