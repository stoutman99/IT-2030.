using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTripLog.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyTripLog.Controllers
{
    public class HomeController : Controller
    {

        private TripLogContext context { get; set; }

        public HomeController(TripLogContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index()
        {
            List<Trip> trips = context.Trips.OrderBy(t => t.Start).ToList();
            return View(trips);
        }
    }
}
