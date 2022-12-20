using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using System.Reflection.Metadata;

namespace ProjektBoat.Pages.EventPages
{
    public class IndexModel : PageModel
    {
        private IEventRepository eventi;


        public List<Event> Event { get; private set; }

        public IndexModel(IEventRepository eventRepository)
        {
            eventi = eventRepository;
        }
        public void OnGet()
        {
            Event = eventi.GetAllEvents();
        }

    }
}



