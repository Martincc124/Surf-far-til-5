using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SurfapplikationAPI.Models;

namespace SurfapplikationAPI.Controllers
{
    [Route("weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {















        // MARtins virker ikke
        //[HttpGet]
        //public async Task<IActionResult> GetWeatherData()
        //{
        //    var weatherdata = new Root();
        //    using (var client = new HttpClient())
        //    {
                
        //        HttpResponseMessage response = await client.GetAsync("https://api.stormglass.io/v2/weather/point?lat=55.403756&lng=10.402370&params=waterTemperature,airTemperature,cloudCover")
              
        //        client.DefaultRequestHeaders.Authorization
        //                 = new AuthenticationHeaderValue("Bearer", "d8ad9e74-28b5-11eb-8ea5-0242ac130002-d8ad9eec-28b5-11eb-8ea5-0242ac130002");
        //        string JSON = await response.Content.ReadAsStringAsync();

        //        weatherdata = JsonConvert.DeserializeObject<Root>(JSON);

        //        return Ok(weatherdata);
        //    }

        //}
    }
}