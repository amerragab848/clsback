using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrainingCenterManagmentSystem.Web.Models;

namespace TrainingCenterManagmentSystem.Web.Controllers
{
   // [Authorize]
    [ApiController]
    [Route("Api/WeatherForecast")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        [Route("AllWeatherForecast")]
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        // DELETE: api/TodoItems/5
        [HttpPost]
        [Route("AddStudent")]
        public  ActionResult AddStudent(StudentVM studentVM)
        {

            List<StudentVM> studentList = new List<StudentVM>() { 
                new StudentVM{
                    ID=1,
                    Name="amer",
                    Address="st1"
                },
                  new StudentVM{
                    ID=2,
                    Name="ragb",
                    Address="st2"
                },  new StudentVM{
                    ID=3,
                    Name="saber",
                    Address="st3"
                }
            };
             studentList.Add(new StudentVM
            {
                ID = 4,
                Name = "abd",
                Address = "st4"
            });

            return Ok();
        }
    }
}
