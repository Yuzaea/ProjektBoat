using System.ComponentModel;

namespace ProjektBoat.Models {
    public class Boat {
        public int BoatId { get; set; }
        public string BoatName { get; set; }
        public int Pier { get; set; }

        public Boat(int boatId, string boatName, int pier) {
            BoatId = boatId;
            BoatName = boatName;
            Pier = pier;
        }

        public Boat() {
        }
    }
}
