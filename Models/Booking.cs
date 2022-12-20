using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjektBoat.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public int UserId { get; set; }

        [Display(Name = "Booking Name")]
        [Required(ErrorMessage = "Name of the Booking is required"), MaxLength(80)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string BoatName { get; set; }

        public DateTime DateTime { get; set; }

        public DateTime TimeFrame { get; set; }
    }
}
