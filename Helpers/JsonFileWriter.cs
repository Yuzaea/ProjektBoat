﻿using ProjektBoat.Models;
using System.Text.Json;
using WebAppPrototype.Models;

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

    }
}
