using ProjektBoat.Helpers;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;

namespace ProjektBoat.Services
{
    public class JsonBoatRepository : IBoatRepository {
        string jsonFileName = @"Data\JsonBoats.json";

        public void AddBoat(Boat bo)
        {
            List<Boat> @boats = GetAllBoats();
            List<int> boatIds = new List<int>();
            foreach (var bok in boats)
            {
                boatIds.Add(bok.BoatId);
            }

            if (boatIds.Count != 0)
            {
                int start = boatIds.Max();
                bo.BoatId = start + 1;
            }
            else
            {
                bo.BoatId = 1;
            }
            @boats.Add(bo);
            JsonFileWriter.WritetoJsonBoats(@boats, jsonFileName);
        }

        public List<Boat> GetAllBoats()
        {
            return JsonFileReader.ReadJsonBoats(jsonFileName);
        }

        public Boat GetBoat(int id)
        {
            foreach (Boat b in GetAllBoats())
            {
                if (b.BoatId == id)
                    return b;
            }
            return new Boat();
        }
    }
}
