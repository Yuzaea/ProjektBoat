using Microsoft.Extensions.Logging;
using ProjektBoat.Helpers;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;

namespace ProjektBoat.Services
{
        public class JsonEventRepository : IEventRepository
        {

        string jsonFileName = @"Data\JsonEvent.json";
        public void AddEvent(Event ev)
        {
            List<Event> events = GetAllEvents();
            events.Add(ev);
            JsonFileWriter.WritetoJsonEvents(events, jsonFileName);

        }
        public void DeleteEvent (int id)
        {
            List<Event> events = GetAllEvents();
            foreach (var item in events)
            {
                if (item.EventID == id)
                {
                    events.Remove(item);
                    JsonFileWriter.WritetoJsonEvents(events, jsonFileName);
                    break;
                }
            }
        }

        public List<Event> GetAllEvents()
        {
            return JsonFileReader.ReadJsonEvent(jsonFileName);
        }

        public Event GetEvent(int id)
        {
            List<Event> events = GetAllEvents();
            foreach (Event item in events)
            {
                if (item.EventID == id)
                    return item;

            }
            return new Event();
        }
        public void UpdateEvent(Event ev)
        {
            if (ev != null)
            {
                List<Event> events = GetAllEvents();
                foreach (Event e in events)
                {
                    if (e.EventID == ev.EventID)
                    {
                        e.EventID = ev.EventID;
                        e.Name = ev.Name;
                        e.Description = ev.Description;
                        e.MaxParticipents = ev.MaxParticipents;
                        e.Date = ev.Date;
                        e.ImageURL = ev.ImageURL;
                        e.participent= ev.participent;
                    }
                }
                JsonFileWriter.WritetoJsonEvents(events, jsonFileName);
            }
        }
        public void AddParticipent(int EventID)
        {
            List<Event> events = GetAllEvents();
            foreach (Event item in events)
            {
                if (item.EventID == EventID)
                    item.participent++;
            }
        }

    }
}
