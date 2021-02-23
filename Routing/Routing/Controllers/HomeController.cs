using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Routing.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Content("Home");
        }

        public IActionResult Privacy()
        {
            return Content("Privacy");
        }

        [Route("[action]/{start}/{end?}/{message?}")]
        public IActionResult Countdown(int start, int end = 0, string message = "")
        {
            string contentString = "Counting down:\n";
            for(int i = start; i >= end; i--)
            {
                contentString += i + "\n";
            }
            return Content(contentString);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
