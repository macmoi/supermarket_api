using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using supermarket_api.Domain.Services;
using supermarket_api.Domain.Models;

namespace supermarket_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ICategoryService _categoryService;   

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        // [HttpGet]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray();
        // }

        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            var Cateories = await _categoryService.ListAsync();
            return Cateories;
        }
    }
}
