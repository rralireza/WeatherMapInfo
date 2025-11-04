using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;
using WeatherMapInfo.Domain.Entities;
using WeatherMapInfo.Domain.ResponseModels;

namespace WeatherMapInfo.Domain.ApiServices;

public sealed class WeathMapApiService
{
    private readonly HttpClient _httpClient;

    private readonly IConfiguration _configuration;

    public WeathMapApiService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<CityWeather> GetCityWeatherAsync(string city)
    {
        //var geoBaseUrl = 
        var geoApiKey = _configuration["Geocoding:ApiKey"];
        var openWeatherBaseUrl = _configuration["OpenWeather:BaseUrl"];
        var openWeatherApiKey = _configuration["OpenWeather:ApiKey"];


        var geocodingUrl = $"{_configuration["Geocoding:BaseUrl"]}direct?q={city}&limit=''&appid={_configuration["Geocoding:ApiKey"]}";
        var geocodingDetails = await _httpClient.GetFromJsonAsync<List<GeoCodingResponse>>(geocodingUrl);

        var lat = geocodingDetails[0].Lat;
        var lon = geocodingDetails[0].Lon;
        var geoCity = geocodingDetails[0].City;

        var weatherUrl = $"{_configuration["OpenWeather:BaseUrl"]}onecall?lat={lat}&lon={lon}&units=metric&exclude=minutely,daily,alerts&appid={_configuration["OpenWeather:ApiKey"]}";
        var weatherDetails = await _httpClient.GetFromJsonAsync<OneCallResponse>(weatherUrl);

        var airUrl = $"{_configuration["AirPollution:BaseUrl"]}air_pollution?lat={lat}&lon={lon}&appid={_configuration["AirPollution:ApiKey"]}"
        var airDetails = await _httpClient.GetFromJsonAsync<AirPollutionResponse>(airUrl);

        CityWeather cityWeatherData = new()
        {
            City = city,
            Lat = lat,
            Lon = lon,
            Current = new()
            {
                Temperature = weatherDetails.Current.Temp,
                Humidity = weatherDetails.Current.Humidity,
                WindSpeed = weatherDetails.Current.WindSpeed,
                Description = weatherDetails.Current.Weather[0].Description
            },
            AirPollution = new()
            {
                AQI = airDetails.List[0].Main.Aqi,
                Pollutants = new()
                {
                    ["co"] = airDetails.List[0].Components.Co,
                    ["no"] = airDetails.List[0].Components.No,
                    ["pm2_5"] = airDetails.List[0].Components.Pm2_5
                }
            }
        };
    }
}
