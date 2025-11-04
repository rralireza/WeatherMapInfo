namespace WeatherMapInfo.Domain.ResponseModels;

public sealed class AirPollutionResponse
{
    public Coord Coord { get; set; }
    public List<AirData> List { get; set; }
}
