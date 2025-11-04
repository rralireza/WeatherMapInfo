using WeatherMapInfo.Domain.Entities;

namespace WeatherMapInfo.Domain.ApiInterfaces;

public interface IWeatherMapApiService
{
    Task<CityWeather> GetCityWeatherAsync(string city);
}
