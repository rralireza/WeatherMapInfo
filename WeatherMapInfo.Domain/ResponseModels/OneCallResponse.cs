namespace WeatherMapInfo.Domain.ResponseModels;

public sealed class OneCallResponse
{
    public double Lat { get; set; }
    public double Lon { get; set; }
    public CurrentWeatherData Current { get; set; }
}

