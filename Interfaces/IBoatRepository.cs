using ProjektBoat.Models;

namespace ProjektBoat.Interfaces {
    public interface IBoatRepository {
        List<Boat> GetAllBoats();
        Boat GetBoat(string boatName);
        void AddBoat(Boat bo);
    }
}
