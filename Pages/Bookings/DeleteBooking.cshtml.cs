using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;

namespace ProjektBoat.Pages.Bookings {
    public class DeleteBookingModel : PageModel
    {
        private IBookingRepository _repo;
        [BindProperty]
        public Booking Booking { get; set; }
        public DeleteBookingModel(IBookingRepository bookingRepo)
        {
            _repo = bookingRepo;
        }
        public void OnGet(int bookingId)
        {
            Booking = _repo.GetBooking(bookingId);
        }
        public IActionResult OnPost()
        {
            _repo.DeleteBooking(Booking);
            return RedirectToPage("Index");
        }
    }
}
