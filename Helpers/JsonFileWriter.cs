using ProjektBoat.Models;
using System.Text.Json;

namespace ProjektBoat.Helpers
{
    public class JsonFileWriter
    {
        public static void WriteToBlogJson(List<BlogPost> blogPosts, string jsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(jsonFileName))
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writer = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<BlogPost[]>(writer, blogPosts.ToArray());
            }
        }
        public static void WritetoJsonBookings(List<Booking> bookings, string jsonFileName) {
            using (FileStream outputStream = File.Create(jsonFileName)) {
                var writer = new Utf8JsonWriter(outputStream, new JsonWriterOptions { SkipValidation = false, Indented = true, });
                JsonSerializer.Serialize<Booking[]>(writer, bookings.ToArray());
            }
        }
        public static void WritetoJsonMember(List<Member> members, string jsonFileName)
        {
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writer = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Member[]>(writer, members.ToArray());
            }
        }
        public static void WritetoJsonEvents(List<Event> events, string jsonFileName)
        {
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writer = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                { SkipValidation = false, Indented = true, });
                JsonSerializer.Serialize<Event[]>(writer, events.ToArray());
            }
        }
    }
}
