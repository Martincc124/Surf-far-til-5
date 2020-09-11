using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Surf_far_til_5.Models;

namespace Surf_far_til_5.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Spot spot = new Spot(50.5f, 80.7f);
            return View(spot);
        }
        
    }
}
