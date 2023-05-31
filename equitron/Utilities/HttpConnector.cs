using System.Net.Http.Json;
using Utilities.Exceptions;

namespace Utilities
{
    public class HttpConnector
    {
        private readonly IHttpClientFactory httpClientFactory;

        public HttpConnector(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<T> Get<T>(string path)
        {
            try
            {
                var httpClient = httpClientFactory.CreateClient();
                var response = await httpClient.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<T>();
                    return content;
                }
                else
                {
                    throw new CustomException(response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                if (ex is CustomException)
                {
                    throw;
                }
                else
                {
                    throw new CustomException(ex.Message);
                }
            }
        }
    }
}
