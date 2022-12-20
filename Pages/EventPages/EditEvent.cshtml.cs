using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;

namespace ProjektBoat.Pages.EventPages
{
    public class EditEventModel : PageModel
    {
        private IEventRepository eventi;
        [BindProperty]
        public Event Event { get; set; }
        public EditEventModel(IEventRepository events)
        {
            eventi = events;
        }

        public void OnGet(int id)
        {
            Event = eventi.GetEvent(id);
        }

        public IActionResult OnPost()
        {
            eventi.UpdateEvent(Event);
            return RedirectToPage("Index");
        }
    }
}

