using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace WeatherForecast_WebApi_.Services.Api
{
    public abstract class ApiService
    {
        protected readonly HttpClient Client;

        protected const string API_KEY = "YOUR API KEY";

        public ApiService(HttpClient client)
        {
            Client = client;

            if (Client.BaseAddress == null)
                Client.BaseAddress = new Uri("https://api.weatherapi.com/v1/");
        }


        protected async Task<T> GetAsync<T>(string url)
        {
            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(json);
        }
    }

}
