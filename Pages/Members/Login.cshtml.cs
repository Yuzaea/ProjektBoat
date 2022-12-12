using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppPrototype.Interfaces;
using WebAppPrototype.Models;
using WebAppPrototype.Services;

namespace WebAppPrototype.Pages.Users {
    public class LoginModel : PageModel {
        private LogInRepository logInRepo;
        private IUserRepository userRepo;
        public string AccessDenied = "";

        [BindProperty]
        public User User { get; set; }

        public LoginModel(IUserRepository repo, LogInRepository logIn)
        {
            userRepo = repo;
            logInRepo = logIn;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            foreach (var user in userRepo.GetAllUsers())
            {
                if (user.Email == User.Email || user.Password == User.Password)
                {
                    logInRepo.UserLogIn(user);
                    return RedirectToPage("/Index");
                }
                AccessDenied = "Email or Password are wrong";
            }
            return Page();
        }
    }
}
