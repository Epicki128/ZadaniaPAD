using System;
using System.Collections.Generic;
using System.Text;
using Location = WeatherForecast_WebApi_.Models.Location;

namespace WeatherForecast_WebApi_.Services.Api
{
    public class SearchService : ApiService
    {
        public SearchService(HttpClient client) : base(client) { }

        public Task<List<Location>> GetSearch(string name)
        {
            return GetAsync<List<Location>>($"search.json?key={API_KEY}&q={name}");
        }
    }

}
