namespace WeatherMapInfo.Domain.Entities;

public sealed class CityWeather
{
    public string City { get; set; }
    public double Lat { get; set; }
    public double Lon { get; set; }
    public CurrentWeather Current { get; set; }
    public AirPollution AirPollution { get; set; }
}

