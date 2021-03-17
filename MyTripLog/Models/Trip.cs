using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyTripLog.Models
{
    public class Trip
    {
        public int TripId { get; set; }

        [Required(ErrorMessage = "Enter a destination")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Enter a start date")]
        public int Start { get; set; }

        [Required(ErrorMessage = "Enter an end date")]
        public int End { get; set; }

        [Required(ErrorMessage = "Enter something")]
        public string Accomodations { get; set; }

        [Required(ErrorMessage ="Enter something")]
        public string Todo { get; set; }

        public string AccomodationPhone { get; set; }

        public string AccomodationEmail { get; set; }

        public string ToDo2 { get; set; }

        public string ToDo3 { get; set; }
    }
}
