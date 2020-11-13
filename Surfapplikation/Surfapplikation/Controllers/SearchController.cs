using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Surfapplikation.Models;

namespace Surfapplikation.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{lon}/{lat}")]
        public async Task<IActionResult> Search(double lon, double lat)
        {
            var result = new List<Root>();
            using (var client = new HttpClient())
            {
                 
                HttpResponseMessage response = await client.GetAsync("https://api.met.no/weatherapi/locationforecast/2.0/compact?lat=" + lat + "&lon=" + lon);

                string JSON = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<List<Root>>(JSON);
                return View(result);
            }
        }
    }
}
