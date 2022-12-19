using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;

namespace ProjektBoat.Pages.Members
{
    public class MemberIndexModel : PageModel
    {
        private IMemberRepository repo;

        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get; set; }
        public List<Member> Members { get; private set; }

        public MemberIndexModel(IMemberRepository memberRepository)
        {
            repo = memberRepository;
        }
        public IActionResult OnGet()
        {
            Members = repo.GetAllMembers();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Members = repo.FilterMembers(FilterCriteria);
            }
            return Page();
        }
        public void OnPost()
        {
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Members = repo.FilterMembers(FilterCriteria);
            }
        }
    }
}
