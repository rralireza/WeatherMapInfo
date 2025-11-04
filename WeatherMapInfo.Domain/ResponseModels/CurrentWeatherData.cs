using System.Text.Json.Serialization;

namespace WeatherMapInfo.Domain.ResponseModels;

public sealed class CurrentWeatherData
{
    public double Temp { get; set; }
    public int Humidity { get; set; }
    [JsonPropertyName("wind_speed")]
    public double WindSpeed { get; set; }
    public List<WeatherDescription> Weather { get; set; }
}

