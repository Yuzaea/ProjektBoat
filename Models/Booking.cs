using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebAppPrototype.Models
{
    public class Booking
    {
        [Required]
        [Range(typeof(int), "0", "50", ErrorMessage = "Id er uden for intervallet")]
        public int BookingId { get; set; }

        [Display(Name = "Booking Name")]
        [Required(ErrorMessage = "Name of the Booking is required"), MaxLength(80)]
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        //[Required(ErrorMessage = "The date is required")]
        //[Range(typeof(DateTime), "11/11/2022", "11/11/2023",
        //ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime DateTime { get; set; }

        //Might not the right var type yet
        public DateTime TimeFrame { get; set; }


        //Might be needed later on
        //public override bool Equals(object? obj) {
        //    if (obj == null) {
        //        return false;
        //    } else {
        //        Booking other = obj as Booking;
        //        if (other.BookingId == BookingId) {
        //            return true;
        //        } else {
        //            return false;
        //        }
        //    }
        //}
    }
}
