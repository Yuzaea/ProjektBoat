using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Models;
using ProjektBoat.Services;

namespace ProjektBoat.Pages.Members
{
    public class LogoutModel : PageModel
    {
        private LogInRepository logInRepo;
        public Member Member { get; set; }
        public LogoutModel(LogInRepository _log)
        {
            logInRepo = _log;
        }
        public IActionResult OnGet()
        {
            if (!logInRepo.GetLoggedMember().Equals(null))
            {
                logInRepo.MemberLogOut();
                return RedirectToPage("/Index");
            }
            else
            {
                Member = logInRepo.GetLoggedMember();
                return RedirectToPage("/Index");
            }
        }
    }
}
