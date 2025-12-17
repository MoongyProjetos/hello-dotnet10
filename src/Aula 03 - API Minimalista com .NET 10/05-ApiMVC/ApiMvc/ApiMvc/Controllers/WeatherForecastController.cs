using Microsoft.AspNetCore.Mvc;

namespace ApiMvc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpGet(Name = "/HelloWorld!")]
        public string HelloWorld()
        {
            return "Hello World!";
        }

        [HttpPost(Name = "/echo")]
        public IResult Echo(HttpRequest request)
        {
            using var reader = new StreamReader(request.Body);
            var body = reader.ReadToEnd();
            return Results.Text(body, "text/plain");
        }

        [HttpPut(Name = "/update/{id}")]
        public IResult UpdateResource(int id, HttpRequest request)
        {
            using var reader = new StreamReader(request.Body);
            var body = reader.ReadToEnd();
            return Results.Text($"Updated resource {id} with data: {body}", "text/plain");
        }
    }
}
