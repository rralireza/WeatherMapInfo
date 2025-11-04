namespace WeatherMapInfo.Domain.ResponseModels;

public sealed class AirData
{
    public AirMain Main { get; set; }
    public AirComponents Components { get; set; }
}
