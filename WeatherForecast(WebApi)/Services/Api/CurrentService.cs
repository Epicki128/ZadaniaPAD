using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecast_WebApi_.Models;

namespace WeatherForecast_WebApi_.Services.Api
{
    public class CurrentService : ApiService
    {
        public CurrentService(HttpClient httpClient) : base(httpClient) { }

        public Task<Current> GetCurrent(string city, string aqi)
        {
            return GetAsync<Current>($"current.json?key={API_KEY}&q={city}&aqi={aqi}");
        }
    }
}
