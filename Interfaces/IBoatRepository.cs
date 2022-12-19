using ProjektBoat.Models;

namespace ProjektBoat.Interfaces
{
    public interface IBoatRepository
    {
        List<Boat> GetAllBoats();
        Boat GetBoat(int id);
        void AddBoat(Boat bo);
    }
}
