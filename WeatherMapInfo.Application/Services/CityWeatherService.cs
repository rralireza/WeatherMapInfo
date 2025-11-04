using WeatherMapInfo.Application.DTO;
using WeatherMapInfo.Application.Interfaces;
using WeatherMapInfo.Domain.ApiInterfaces;

namespace WeatherMapInfo.Application.Services;

public sealed class CityWeatherService : ICityWeatherService
{
    private readonly IWeatherMapApiService _service;

    public CityWeatherService(IWeatherMapApiService service)
    {
        _service = service;
    }

    public async Task<CityWeatherResponseDto> GetCityWeatherDetailsAsync(string city)
    {
        var data = await _service.GetCityWeatherAsync(city);

        CityWeatherResponseDto result = new()
        {
            Temperature = data.Current.Temperature,
            Humidity = data.Current.Humidity,
            WindSpeed = data.Current.WindSpeed,
            AQI = data.AirPollution.AQI,
            MajorPollutants = data.AirPollution.Pollutants,
            GeographicalCoordinates = new()
            {
                ["Latitude"] = data.Lat,
                ["Longitude"] = data.Lon
            },
        };

        return result;
    }
}
