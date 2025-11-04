namespace WeatherMapInfo.Domain.Entities;

public sealed class CurrentWeather
{
    public double Temperature { get; set; }
    public int Humidity { get; set; }
    public double WindSpeed { get; set; }
    public string Description { get; set; }
}

