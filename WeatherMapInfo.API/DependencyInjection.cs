namespace WeatherMapInfo.API;

public static class DependencyInjection
{
    public static IServiceCollection Configuration(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddOpenApi();

        return services;
    }
}
