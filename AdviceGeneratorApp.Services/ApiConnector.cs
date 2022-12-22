using AdviceGeneratorApp.Models;
using AdviceGeneratorApp.Services.Interfaces;
using System.Net;
using System.Net.Http.Json;

namespace AdviceGeneratorApp.Services
{
    public class ApiConnector<T> : IApiConnector<T>
    {
        private readonly HttpClient _httpClient;

        public ApiConnector(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T?> GetAsync(string requestUri)
        {
            var response = await _httpClient.GetAsync(requestUri);

            response.EnsureSuccessStatusCode();

            if (response.StatusCode == HttpStatusCode.NoContent) return default;

            return await response.Content.ReadFromJsonAsync<T>();
        }
    }
}