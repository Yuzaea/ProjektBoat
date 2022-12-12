using ProjektBoat.Models;
using System.Text.Json;

namespace ProjektBoat.Helpers
{
    public class JsonFileReader
    {
        public static List<BlogPost> ReadBlogJson(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<BlogPost>>(indata);
            }
        }
        public static List<Booking> ReadJsonBookings(string jsonFileName) {
            using (var jsonFileReader = File.OpenText(jsonFileName)) {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Booking>>(indata);
            }
        }
    }
}
