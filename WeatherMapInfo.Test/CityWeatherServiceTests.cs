using Moq;
using WeatherMapInfo.Application.Interfaces;
using WeatherMapInfo.Application.Services;
using WeatherMapInfo.Domain.ApiInterfaces;
using WeatherMapInfo.Domain.Entities;

namespace WeatherMapInfo.Test;

public class CityWeatherServiceTests
{
    private readonly Mock<IWeatherMapApiService> _apiServiceMock;
    private readonly ICityWeatherService _service;

    public CityWeatherServiceTests()
    {
        _apiServiceMock = new Mock<IWeatherMapApiService>();
        _service = new CityWeatherService(_apiServiceMock.Object);
    }

    [Fact]
    public async Task GetCityWeatherDetailsAsync_ShouldReturnData_WhenCityIsValid()
    {
        // Arrange
        var sampleCityWeather = new CityWeather
        {
            City = "Tehran",
            Lat = 35.6892,
            Lon = 51.3890,
            Current = new()
            {
                Temperature = 22.5,
                Humidity = 40,
                WindSpeed = 2.5,
                Description = "clear sky"
            },
            AirPollution = new()
            {
                AQI = 2,
                Pollutants = new Dictionary<string, double> { ["co"] = 200 }
            }
        };

        _apiServiceMock.Setup(x => x.GetCityWeatherAsync("Tehran")).ReturnsAsync(sampleCityWeather);

        // Act
        var result = await _service.GetCityWeatherDetailsAsync("Tehran");

        // Assert
        Assert.NotNull(result);
        Assert.Equal(22.5, result.Temperature);
        Assert.Equal(40, result.Humidity);
    }

    [Fact]
    public async Task GetCityWeatherDetailsAsync_ShouldThrowException_WhenCityNotFound()
    {
        // Arrange
        _apiServiceMock.Setup(x => x.GetCityWeatherAsync("Nowhere"))
                .ThrowsAsync(new Exception("City not found"));

        // Act & Assert
        await Assert.ThrowsAsync<Exception>(() =>
            _service.GetCityWeatherDetailsAsync("Nowhere"));
    }
}
