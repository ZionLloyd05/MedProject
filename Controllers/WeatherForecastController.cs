using MediatR;
using MedProject.CreateBiller;
using Microsoft.AspNetCore.Mvc;

namespace MedProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISender sender;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ISender sender, ILogger<WeatherForecastController> logger)
        {
            this.sender = sender;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<NewBillerResponse> Get()
        {
            var result = await sender.Send(new CreateBillerCommand());

            return new NewBillerResponse(Guid.NewGuid());
        }
    }
}