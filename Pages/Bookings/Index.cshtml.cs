using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using ProjektBoat.Services;

namespace ProjektBoat.Pages.Bookings {
    public class IndexModel : PageModel
    {
        private IBookingRepository _repo;
        private LogInRepository _logInRepo;

        public Member Member { get; set; }
        
        public List<Booking> Bookings { get; private set; }
        public IndexModel(IBookingRepository repo, LogInRepository logInRepo)
        {
            _repo = repo;
            _logInRepo = logInRepo;
        }
        public IActionResult OnGet()
        {
            if (_logInRepo.GetLoggedMember().Equals(null))
            {
                return RedirectToPage("Users/Login");
            }
            else
            {
                Member = _logInRepo.GetLoggedMember();
                Bookings = _repo.GetAllBookingsByMember(Member);
                return Page();
            }
        }
    }
}