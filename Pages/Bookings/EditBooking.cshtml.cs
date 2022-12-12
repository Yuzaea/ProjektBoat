using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;

namespace WebAppPrototype.Pages.Bookings {
    public class EditBookingModel : PageModel {
        private IBookingRepository _repo;

        [BindProperty]
        public Booking Booking { get; set; }

        public EditBookingModel(IBookingRepository bookingRepo) {
            _repo = bookingRepo;
        }
        public IActionResult OnGet(int bookingId) {
            Booking = _repo.GetBooking(bookingId);
            return Page();
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }
            _repo.UpdateBooking(Booking);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostEdit() {
            if (!ModelState.IsValid) {
                return Page();
            }
            _repo.UpdateBooking(Booking);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostDelete(int bookingId) {
            if (!ModelState.IsValid) {
                return Page();
            }
            _repo.DeleteBooking(bookingId);
            return RedirectToPage("Index");
        }
    }
}
