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
using SurfapplikationAPI.Models;

namespace SurfapplikationAPI.Controllers
{
    [ApiVersion("1.0")]
    [Route("weather")]
    [ApiController]
    public class WeatherController : ControllerBase
    {

        [HttpGet("{lat}/{lng}")]
        public async Task<IActionResult> GetWeatherData(decimal lat, decimal lng)
        {
            Root weatherdata = new Root();
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage();
                DateTime date = DateTime.UtcNow;
                request.RequestUri = new Uri($"https://api.stormglass.io/v2/weather/" +
                    $"point?lat=" + lat + "&lng=" + lng + "&" +
                    $"params=waterTemperature,airTemperature,cloudCover&start=" + date.ToString("yyyy-MM-ddTHH\\:mm\\:ss") + "&" +
                    $"end=" + date.ToString("yyyy-MM-ddTHH\\:mm\\:ss"));

                request.Headers.Add("Authentication-Token", "ede82dc6-2014-11eb-8ea5-0242ac130002-ede82e8e-2014-11eb-8ea5-0242ac130002");

                HttpResponseMessage response = await client.SendAsync(request);
                string JSON = await response.Content.ReadAsStringAsync();

                weatherdata = JsonConvert.DeserializeObject<Root>(JSON);

            }
            return Ok(weatherdata);
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> GetWeatherFromCity(string city)
        {
    
            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage();
                request.RequestUri = new Uri($"https://eu1.locationiq.com/v1/search.php?key=pk.d36e64f7f24afa3ba6fc119b04721177&q=" + city + "&format=json");

                HttpResponseMessage response = await client.SendAsync(request);
                string JSON = await response.Content.ReadAsStringAsync();
          
                return Ok(JSON);
            }
            
        }


        // query string to get geolocation of a city https: //eu1.locationiq.com/v1/search.php?key=pk.d36e64f7f24afa3ba6fc119b04721177&q=Odense&format=json

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