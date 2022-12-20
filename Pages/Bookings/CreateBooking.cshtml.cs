using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using ProjektBoat.Services;

namespace ProjektBoat.Pages.Bookings {
    public class CreateBookingModel : PageModel
    {
        private IBookingRepository _bookingRepo;
        private LogInRepository _loggedInMember;
        private IBoatRepository _boatRepo;
        private IMemberRepository _memberRepo;


        public SelectList BoatId { get; set; }

        [BindProperty]
        public Booking Booking { get; set; }
        public Member Member { get; set; }
        public CreateBookingModel(IBookingRepository bookingRepo, LogInRepository loggedInMember, IBoatRepository _boatRepo)
        {
            _bookingRepo = bookingRepo;
            _loggedInMember = loggedInMember;
            List<Boat> boats = _boatRepo.GetAllBoats();
            BoatId = new SelectList(boats, "BoatId", "BoatName");
        }

        public IActionResult OnGet()
        {
            if (_loggedInMember.GetLoggedMember().Equals(null))
            {
                return RedirectToPage("Users/Login");
            }
            else
            {
                Member = _loggedInMember.GetLoggedMember();
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            Booking.UserId = _loggedInMember.GetLoggedMember().ID;
            _bookingRepo.AddBooking(Booking);
            return RedirectToPage("Index");
        }
    }
}
