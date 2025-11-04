using System.Text.Json.Serialization;

namespace WeatherMapInfo.Domain.ResponseModels;

public sealed class MainData
{
    public double Temp { get; set; }
    [JsonPropertyName("feels_like")]
    public double FeelsLike { get; set; }
    public int Humidity { get; set; }
    public int Pressure { get; set; }
}
