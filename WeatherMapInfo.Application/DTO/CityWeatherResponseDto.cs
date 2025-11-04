namespace WeatherMapInfo.Application.DTO;

public sealed class CityWeatherResponseDto
{
    public string City { get; set; }

    public double Temperature { get; set; }

    public int Humidity { get; set; }

    public double WindSpeed { get; set; }

    public int AQI { get; set; }

    //public double Latitude { get; set; }

    //public double Longitude { get; set; }

    public Dictionary<string, double> GeographicalCoordinates { get; set; }

    public Dictionary<string, double> MajorPollutants { get; set; }
}
