using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using WeatherForecast_WebApi_.Services.Api;
using WeatherForecast_WebApi_.Services.Files;

namespace WeatherForecast_WebApi_
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("NationalPark-Light.ttf", "NationalParkLight");
                    fonts.AddFont("NationalPark-Regular.ttf", "NationalParkRegular");
                })
                .Services.AddSingleton<HttpClient>()
                .AddSingleton<CurrentService>()
                .AddSingleton<ForecastService>()
                .AddSingleton<SearchService>()
                .AddSingleton<WeatherConditionsService>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
