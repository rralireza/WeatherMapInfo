using System.Text.Json.Serialization;

namespace WeatherMapInfo.Domain.ResponseModels;

public sealed class WindData
{
    [JsonPropertyName("speed")]
    public double Speed { get; set; }
}
