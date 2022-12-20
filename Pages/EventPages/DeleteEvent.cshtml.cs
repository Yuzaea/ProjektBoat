using ProjektBoat.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Models;


namespace ProjektBoat.Pages.EventPages
{
        public class DeleteEventModel : PageModel
        {
            private IEventRepository events;

            [BindProperty]
            public Event Event { get; set; }
            public DeleteEventModel(IEventRepository eventi)
            {
            events = eventi;
            }
            public void OnGet(int id)
            {
                Event = events.GetEvent(id);
            }
            public IActionResult OnPost()
            {
            events.DeleteEvent(Event.EventID);
                return RedirectToPage("Index");
            }
        }
    }