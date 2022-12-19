using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;

namespace ProjektBoat.Pages.Members
{
    public class DeleteMemberModel : PageModel
    {
        [BindProperty]
        public Member Member { get; set; }

        private IMemberRepository _repo;

        public DeleteMemberModel(IMemberRepository repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            _repo.AddMember(Member);
        }
    }
}
