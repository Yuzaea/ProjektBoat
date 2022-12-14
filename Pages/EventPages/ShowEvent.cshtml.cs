using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;
using System.Reflection.Metadata;

namespace ProjektBoat.Pages.EventPages
{
    public class ShowEventModel : PageModel
    {
        private IEventRepository eventi;

        [BindProperty]
        public Event Event { get; private set; }
        public ShowEventModel(IEventRepository evente)
        {
            eventi = evente;
        }
        public void OnGet(int id)
        {
            Event = eventi.GetEvent(id);
        }
    }
}
