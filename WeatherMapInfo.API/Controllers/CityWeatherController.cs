using Microsoft.AspNetCore.Mvc;
using WeatherMapInfo.Application.Interfaces;

namespace WeatherMapInfo.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityWeatherController : ControllerBase
{
    private readonly ICityWeatherService _service;

    public CityWeatherController(ICityWeatherService service)
    {
        _service = service;
    }

    [HttpGet(nameof(Details))]
    public async Task<IActionResult> Details(string city)
    {
        try
        {
            var response = await _service.GetCityWeatherDetailsAsync(city);

            if (response == null)
            {
                return NotFound($"Weather data for city '{city}' not found.");
            }

            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
