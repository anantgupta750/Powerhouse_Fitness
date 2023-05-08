using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class SummeriestController : ControllerBase
{
	private static readonly string[] Summaries = new[]
	{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

	public SummeriestController()
	{ }

	[HttpGet(Name = "GetWeatherForecast")]
	public IEnumerable<string> Get()
	{
		return Summaries;
	}
}
