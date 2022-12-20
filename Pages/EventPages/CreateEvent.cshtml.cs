using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;

namespace ProjektBoat.Pages.EventPages
{
    public class CreateEventModel : PageModel
    {
        private IEventRepository eventi;

        [BindProperty]
        public Event Event { get; set; }

        public CreateEventModel(IEventRepository eventRepository)
        {
            eventi = eventRepository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            eventi.AddEvent(Event);
            return RedirectToPage("Index");
        }
    }
}