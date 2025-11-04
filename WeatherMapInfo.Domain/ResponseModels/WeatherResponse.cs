namespace WeatherMapInfo.Domain.ResponseModels;

public sealed class WeatherResponse
{
    public Coord Coord { get; set; }
    public List<WeatherDescription> Weather { get; set; }
    public MainData Main { get; set; }
    public WindData Wind { get; set; }
    public string Name { get; set; }
}
