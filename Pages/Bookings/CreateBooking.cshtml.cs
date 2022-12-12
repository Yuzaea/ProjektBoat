using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using ProjektBoat.Services;

namespace ProjektBoat.Pages.Bookings {
    public class CreateBookingModel : PageModel {
        private IBookingRepository _bookingRepo;
        private LogInRepository _loggedInUser;
        //private IBoatRepository _boatRepo;

        //public SelectList BoatNames { get; set; }

        [BindProperty]
        public Booking Booking { get; set; }
        public Member Member { get; set; }
        public CreateBookingModel(IBookingRepository bookingRepo, LogInRepository loggedInUser, /*IBoatRepository boatRepo*/) {
            _bookingRepo = bookingRepo;
            _loggedInUser = loggedInUser;
            //_boatRepo = boatRepo;
            //List<Boat> Boats = _boatRepo.GetAllBoats();
            //BoatNames = new SelectList(Boats, "Id", "Name");
        }
        public IActionResult OnGet() {
            //Member = _loggedInMember.GetLoggedMember();
            return Page();
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }
            _bookingRepo.AddBooking(Booking);
            return RedirectToPage("Index");
        }
    }
}
