using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecast_WebApi_.Models;

namespace WeatherForecast_WebApi_.Services.Api
{
    public class ForecastService : ApiService
    {
        public ForecastService(HttpClient httpClient) : base(httpClient) { }

        public Task<ForecastResponse> GetForecast(string city, int days, string aqi, string alerts)
        {
            return GetAsync<ForecastResponse>($"forecast.json?key={API_KEY}&q={city}&days={days}&aqi={aqi}&alerts={alerts}");
        }
    }


}
