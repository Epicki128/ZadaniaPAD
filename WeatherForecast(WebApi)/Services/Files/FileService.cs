using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui.Storage;
using System.IO;
using System.Text.Json;

namespace WeatherForecast_WebApi_.Services.Files
{
    public abstract class FileService
    {
        protected async Task<T> GetAsync<T>(string file) where T : new()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync(file);
            using var reader = new StreamReader(stream);

            string json = await reader.ReadToEndAsync();

            return JsonSerializer.Deserialize<T>(json) ?? new T();
        }
    }
}
