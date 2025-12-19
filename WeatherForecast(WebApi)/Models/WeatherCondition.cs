using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherForecast_WebApi_.Models
{
    public class WeatherCondition
    {
        public int code { get; set; }
        public string day { get; set; }
        public string night { get; set; }
        public int icon { get; set; }
    }
}
