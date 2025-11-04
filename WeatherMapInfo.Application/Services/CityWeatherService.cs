using WeatherMapInfo.Application.DTO;
using WeatherMapInfo.Domain.ApiInterfaces;

namespace WeatherMapInfo.Application.Services;

public sealed class CityWeatherService
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
            City = data.City,
            Latitude = data.Lat,
            Longitude = data.Lon,
            Temperature = data.Current.Temperature,
            Humidity = data.Current.Humidity,
            WindSpeed = data.Current.WindSpeed,
            AQI = data.AirPollution.AQI,
            MajorPollutants = data.AirPollution.Pollutants
        };

        return result;
    }
}
