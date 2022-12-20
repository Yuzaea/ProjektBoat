using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProjektBoat.Models;
using ProjektBoat.Interfaces;
using ProjektBoat.Helpers;

namespace ProjektBoat.Pages.Boats
{
    public class IndexModel : PageModel
    {
        private IBoatRepository _repo;
        public List<Boat> Boats { get; private set; }
        public IndexModel(IBoatRepository repo)
        {
            _repo = repo;
        }
        public IActionResult OnGet()
        {
            Boats = _repo.GetAllBoats();
            return Page();
        }
    }
}
