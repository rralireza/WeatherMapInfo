namespace WeatherMapInfo.Domain.Entities;

public sealed class AirPollution
{
    public int AQI { get; set; }
    public Dictionary<string, double> Pollutants { get; set; }
}

