using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;

namespace WebAppPrototype.Pages.Bookings {
    public class DeleteBookingModel : PageModel {
        private IBookingRepository _repo;
        [BindProperty]
        public Booking Booking { get; set; }
        public DeleteBookingModel(IBookingRepository bookingRepo) {
            _repo = bookingRepo;
        }
        public void OnGet(int bookingId) {
            Booking = _repo.GetBooking(bookingId);
        }
        public IActionResult OnPost() {
            _repo.DeleteBooking(Booking.BookingId);
            return RedirectToPage("Index");
        }
    }
}
