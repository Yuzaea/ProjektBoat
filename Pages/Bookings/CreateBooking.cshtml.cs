using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;
using WebAppPrototype.Services;

namespace WebAppPrototype.Pages.Bookings {
    public class CreateBookingModel : PageModel {
        private IBookingRepository _bookingRepo;
        private LogInRepository _loggedInUser;
        private IBoatRepository _boatRepo;

        public SelectList BoatNames { get; set; }

        [BindProperty]
        public Booking Booking { get; set; }
        public User User { get; set; }
        public CreateBookingModel(IBookingRepository bookingRepo, LogInRepository loggedInUser, IBoatRepository boatRepo) {
            _bookingRepo = bookingRepo;
            _loggedInUser = loggedInUser;
            _boatRepo = boatRepo;
            List<Boat> Boats = _boatRepo.GetAllBoats();
            BoatNames = new SelectList(Boats, "Id", "Name");
        }
        public IActionResult OnGet() {
            //User = _loggedInUser.GetLoggedUser();
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
