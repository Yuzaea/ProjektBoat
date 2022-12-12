using Microsoft.Extensions.Logging;
using ProjektBoat.Models;



namespace ProjektBoat.Interfaces
{
    public interface IEventRepository
    {
    public int Count { get; }
    List<Event> GetAllEvents();
    Event SearchEvent(int EventID);
    void AddEvent(Event ev);

    void UpdateEvent(Event ev);

        void AddParticipent(int EventID);

    }

}
