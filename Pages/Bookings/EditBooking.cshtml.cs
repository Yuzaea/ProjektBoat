using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;

namespace ProjektBoat.Pages.Bookings {
    public class EditBookingModel : PageModel
    {
        private IBookingRepository _repo;
        private IBoatRepository _boatRepo;

        [BindProperty]
        public Booking Booking { get; set; }
        public SelectList BoatName { get; set; }
        public EditBookingModel(IBookingRepository bookingRepo, IBoatRepository boatRepo)
        {
            _repo = bookingRepo;
            _boatRepo = boatRepo;
            List<Boat> Boats = _boatRepo.GetAllBoats();
            BoatName = new SelectList(Boats, "BoatId", "BoatName");
        }
        public IActionResult OnGet(int bookingId)
        {
            Booking = _repo.GetBooking(bookingId);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repo.UpdateBooking(Booking);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostEdit()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repo.UpdateBooking(Booking);
            return RedirectToPage("Index");
        }
        public IActionResult OnPostDelete()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repo.DeleteBooking(Booking);
            return RedirectToPage("Index");
        }
    }
}
