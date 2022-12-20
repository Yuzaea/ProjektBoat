using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Models;
using ProjektBoat.Interfaces;

namespace ProjektBoat.Pages.Members
{
    public class AddMemberModel : PageModel
    {

        [BindProperty]
        public Member Member { get; set; }

        private IMemberRepository _repo;

        public AddMemberModel(IMemberRepository repo)
        {
            _repo= repo;
        }
        public void OnGet()
        {

        }
       
        public IActionResult OnPost()
        {
            _repo.AddMember(Member);
            return RedirectToPage("/Index");
        }
    }
}
