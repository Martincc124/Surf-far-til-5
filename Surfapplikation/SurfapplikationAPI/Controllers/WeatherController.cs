using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
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
            Root weatherdata = new Root();
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage();
                request.RequestUri = new Uri("https://api.stormglass.io/v2/weather/point?lat=55.403756&lng=10.402370&params=waterTemperature,airTemperature,cloudCover");
                request.Headers.Add("Authentication-Token", "ede82dc6-2014-11eb-8ea5-0242ac130002-ede82e8e-2014-11eb-8ea5-0242ac130002");
                request.Content = new StringContent("{'lat' : 55.6,'lng' : 9.9,'params' : 'waveHeight'}", Encoding.UTF8, "application/json");
                
                HttpResponseMessage response = await client.SendAsync(request);

                string JSON = await response.Content.ReadAsStringAsync();

                weatherdata = JsonConvert.DeserializeObject<Root>(JSON);

                return Ok(weatherdata);
            }

        }
    }
}