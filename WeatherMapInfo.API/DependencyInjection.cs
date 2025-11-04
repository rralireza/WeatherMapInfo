using WeatherMapInfo.Application.Interfaces;
using WeatherMapInfo.Application.Services;
using WeatherMapInfo.Domain.ApiInterfaces;
using WeatherMapInfo.Domain.ApiServices;

namespace WeatherMapInfo.API;

public static class DependencyInjection
{
    public static IServiceCollection Configuration(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddOpenApi();
        services.AddHttpClient<IWeatherMapApiService, WeatherMapApiService>();
        services.AddScoped<ICityWeatherService, CityWeatherService>();

        return services;
    }
}
