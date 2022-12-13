using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using ProjektBoat.Services;

namespace ProjektBoat.Pages.Members {
    public class LoginModel : PageModel {
        private LogInRepository logInRepo;
        private IMemberRepository memberRepo;
        public string AccessDenied = "";

        [BindProperty]
        public Member Member { get; set; }

        public LoginModel(IMemberRepository repo, LogInRepository logIn)
        {
            memberRepo = repo;
            logInRepo = logIn;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            //foreach (var member in memberRepo.GetAllMembers())
            //{
            //    if (member.Email == Member.Email || member.Password == Member.Password)
            //    {
            //        logInRepo.MemberLogIn(member);
            //        return RedirectToPage("/Index");
            //    }
            //    AccessDenied = "Email or Password are wrong";
            //}
            return Page();
        }
    }
}
