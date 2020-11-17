using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Surfapplikation.Models;

namespace SurfapplikationAPI.Controllers
{
    [Route("weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetWeatherData()
        {
            List<Root> weatherdata = new List<Root>();
            using (var client = new HttpClient())
            {
              
                HttpResponseMessage response = await client.GetAsync("https://api.met.no/weatherapi/locationforecast/2.0/compact?lat=10&lon=20");

                string JSON = await response.Content.ReadAsStringAsync();

                weatherdata = JsonConvert.DeserializeObject<List<Root>>(JSON);

                return Ok(weatherdata);
            }

        }
    }
}