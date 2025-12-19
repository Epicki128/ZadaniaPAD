using System;
using System.Collections.Generic;
using System.Text;
using WeatherForecast_WebApi_.Models;

namespace WeatherForecast_WebApi_.Services.Files
{
    public class WeatherConditionsService : FileService
    {
        public Task<List<WeatherCondition>> GetConditions()
        {
            return GetAsync<List<WeatherCondition>>("weather_conditions.json");
        }
    }
}
