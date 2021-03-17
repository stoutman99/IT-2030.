using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTripLog.Controllers
{
        public class TripController : Controller
    {
        public TripLogContext context { get; set; }

        public TripController(TripLogContext context) => this.context = context;

        public RedirectToActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }

}
