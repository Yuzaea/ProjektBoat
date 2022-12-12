using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using System.Reflection.Metadata;

namespace ProjektBoat.Pages.EventPages
{
    public class IndexModel : PageModel
    {
        private IEventRepository repo;


        private List<Event> Eventi { get; }

        public List<Event> Events { get; set; }
        public IndexModel(IEventRepository eventRepository)
        {
            repo = eventRepository;
        }
        public void OnGet()
        {
            Events = repo.GetAllEvents();
        }

        public List<Event> participents { get; set; }
        public void OnPostAddParticipent()
        {
            
        }

    }
}

