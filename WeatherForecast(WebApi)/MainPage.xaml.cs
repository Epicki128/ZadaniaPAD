using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherForecast_WebApi_.Models;
using WeatherForecast_WebApi_.Services.Api;
using WeatherForecast_WebApi_.Services.Files;
using Location = WeatherForecast_WebApi_.Models.Location;

namespace WeatherForecast_WebApi_
{
    public partial class MainPage : ContentPage
    {

        private readonly ForecastService _forecastService;
        private readonly SearchService _searchService;
        private readonly WeatherConditionsService _weatherConditionsService;

        ForecastResponse forecastResponse;
        List<Location> search;
        List<WeatherCondition> conditions;

        private async Task SetForecast(string city, int days, string aqi, string alerts)
        {
            ActivityIndicator activityIndicator = new ActivityIndicator() { IsRunning = true };
            forecastResponse = await _forecastService.GetForecast(city, days, aqi, alerts);
            activityIndicator.IsRunning = false;
        }

        private async Task SetSearch(string city)
        {
            search = await _searchService.GetSearch(city);
        }


        public MainPage(ForecastService forecastService, SearchService searchService, WeatherConditionsService weatherConditionsService)
        {
            InitializeComponent();
            _forecastService = forecastService;
            _searchService = searchService;
            _weatherConditionsService = weatherConditionsService;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            conditions = await _weatherConditionsService.GetConditions();

            await Forecast();
        }

        private async Task Forecast()
        {
            string city = EntryCity.Text;

            if (string.IsNullOrEmpty(city))
            {
                city = "Jaroslaw";
            }

            await SetForecast(city, 7, "no", "no");

            forecastResponse.current.condition.icon.Replace("64x64", "128x128");
            forecastResponse.forecast.forecastday.ForEach(i => i.day.condition.icon.Replace("64x64", "128x128"));

            ImageWeatherSmall.Source = "https:" + forecastResponse.current.condition.icon;
            ImageWeatherBig.Source = "https:" + forecastResponse.current.condition.icon;

            LabelCitySmall.Text = forecastResponse.location.name;
            LabelCityBig.Text = forecastResponse.location.name;

            LabelLatitude.Text = "Lat: " + forecastResponse.location.lat.ToString();

            LabelLongtitude.Text = "Lon: " + forecastResponse.location.lon.ToString();

            LabelCurrentTemperature.Text = forecastResponse.current.temp_c + "\u00B0C";

            LabelCurrentWindSpeed.Text = forecastResponse.current.wind_kph + " km/h";

            LabelCurrentPressure.Text = forecastResponse.current.pressure_mb.ToString() + " hPa";

            LabelCurrentHumidity.Text = forecastResponse.current.humidity + "%";

            LabelCurrentCloudCoverage.Text = forecastResponse.current.cloud + "%";

            LabelCurrentPrecipitation.Text = forecastResponse.current.precip_mm + "mm";

            if (forecastResponse.current.is_day == 1)
            {
                LabelCurrentWeatherDescription.Text = conditions.Find(i => i.code == forecastResponse.current.condition.code).day;
            }
            else
            {
                LabelCurrentWeatherDescription.Text = conditions.Find(i => i.code == forecastResponse.current.condition.code).night;
            }



            BindableLayout.SetItemsSource(DayTiles, forecastResponse.forecast.forecastday);

        }


        private void UpdateSuggestionsPosition()
        {
            if (!Suggestions.IsVisible)
                return;

            var parent = EntryCity.Parent;

            var x = EntryCity.X + double.Parse(parent.GetValue(XProperty).ToString()) + double.Parse(parent.Parent.GetValue(XProperty).ToString());
            var y = EntryCity.Y + EntryCity.Height + double.Parse(parent.GetValue(YProperty).ToString()) + double.Parse(parent.Parent.GetValue(YProperty).ToString());
            var width = EntryCity.Width;

            AbsoluteLayout.SetLayoutBounds(
                Suggestions,
                new Rect(x, y, width, -1)
            );
        }

        public void EntryCityFocused(object sender, FocusEventArgs e)
        {
            if (e.IsFocused)
            {
                Suggestions.IsVisible = true;
                UpdateSuggestionsPosition();
            }
            else
            {
                Suggestions.IsVisible = false;
            }
        }

        public async void EntryCityTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateSuggestionsPosition();

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                SuggestionsList.ItemsSource = null;
                return;
            }

            await SetSearch(e.NewTextValue);

            List<string> suggestions = new List<string>();

            search.ForEach((location) =>
            {
                suggestions.Add(location.name);
            });

            suggestions.Sort();

            SuggestionsList.ItemsSource = suggestions;
        }

        private void SuggestionsListSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EntryCity.Text = SuggestionsList.SelectedItem.ToString();
            EntryCity.Unfocus();
        }


        private void SelectForecastDay(object sender, EventArgs e)
        {
            GridForecastDayDetails.IsVisible = true;

            Day day = (Day)(((ForecastDay)((FlexLayout)sender).BindingContext)).day;

            LabelForecastDayWeatherDescription.Text = conditions.Find(item => item.code == day.condition.code).day;

            LabelForecastDayTempMin.Text = day.mintemp_c + "\u00B0C";
            LabelForecastDayTempAvg.Text = day.avgtemp_c + "\u00B0C";
            LabelForecastDayTempMax.Text = day.maxtemp_c + "\u00B0C";

            LabelForecastDayWindSpeed.Text = day.maxwind_kph + "km/h";

            LabelForecastDayPrecipitation.Text = day.totalprecip_mm + "mm";

            LabelForecastDaySnow.Text = day.totalsnow_cm + "cm";

            LabelForecastDayVisibility.Text = day.avgvis_km + "km";

            LabelForecastDayHumidity.Text = day.avghumidity + "%";

            LabelForecastDayRainChance.Text = day.daily_chance_of_rain + "%";

            LabelForecastDaySnowChance.Text = day.daily_chance_of_snow + "%";

        }

        private async void Forecaster(object sender, EventArgs e)
        {
            Forecast();
        }

    }


}
