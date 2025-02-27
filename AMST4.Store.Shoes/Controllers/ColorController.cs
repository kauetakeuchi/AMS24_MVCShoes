using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AMST4.Store.Shoes.Controllers
{
    [Route("[controller]")]
    public class ColorController : Controller
    {
        private readonly ILogger<ColorController> _logger;

        public ColorController(ILogger<ColorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Color()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}