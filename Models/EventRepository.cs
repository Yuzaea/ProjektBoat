using Microsoft.Extensions.Logging;
using ProjektBoat.Interfaces;

namespace ProjektBoat.Models
{
    public class EventRepository:IEventRepository
    {

        private List<Event> Eventi { get; }

        public EventRepository()
        {
            Eventi = new List<Event>();
            Event b1 = new Event(5, "Celeste", DateTime.Today, "https://www.godownsize.com/wp-content/uploads/2019/07/dory.jpg", "vi sejler både (:",50);
            Eventi.Add(b1);

        }

        public int Count
        {
            get { return Eventi.Count; }
        }


        public void AddEvent(Event aEvent)
        {
            Event foundEvent = SearchEvent(aEvent.EventID);
            if (foundEvent == null)
            {
                Eventi.Add(aEvent);
            }

        }
        public Event SearchEvent(int number)
        {

            foreach (Event item in Eventi)
            {
                if (item.EventID == number)
                    return item;
            }
            return null;
        }

        public List<Event> GetAllEvents()
        {

            List<Event> list = new List<Event>();
            foreach (Event aEvent in Eventi)
            {
                list.Add(aEvent);
            }
            return list;
        }
        public void UpdateEvent(Event ev)
        {
            if (ev != null)
            {
                foreach (Event e in Eventi)
                {
                    if (e.EventID == ev.EventID)
                    {
                        e.EventID = ev.EventID;
                        e.Name = ev.Name;
                        e.Date = e.Date;
                        e.ImageURL = ev.ImageURL;

                    }
                }
            }
        }

        public void AddParticipent(int number)
        {
            foreach (Event item in Eventi)
            {
                if (item.EventID == number)
                    item.participent++;
            }
        }

    }
}
