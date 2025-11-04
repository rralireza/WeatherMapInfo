namespace WeatherMapInfo.Domain.ResponseModels;

public sealed class GeoCodingResponse
{
    public string City { get; set; }
    public double Lat { get; set; }
    public double Lon { get; set; }
    public string Country { get; set; }
}
