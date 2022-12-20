using Microsoft.Extensions.Logging;
using ProjektBoat.Models;



namespace ProjektBoat.Interfaces
{
    public interface IEventRepository
    {
    List<Event> GetAllEvents();
    Event GetEvent(int id);
    void AddEvent(Event ev);
    void DeleteEvent(int id);

    void UpdateEvent(Event ev);

    void AddParticipent(int EventID);

    }

}
