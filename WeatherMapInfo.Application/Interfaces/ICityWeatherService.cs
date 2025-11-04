using WeatherMapInfo.Application.DTO;

namespace WeatherMapInfo.Application.Interfaces;

public interface ICityWeatherService
{
    Task<CityWeatherResponseDto> GetCityWeatherDetailsAsync(string city);
}
