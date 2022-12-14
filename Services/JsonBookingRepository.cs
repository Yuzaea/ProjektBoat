using Microsoft.Extensions.Logging;
using ProjektBoat.Helpers;
using ProjektBoat.Interfaces;
using ProjektBoat.Models;

namespace ProjektBoat.Services {
    public class JsonBookingRepository : IBookingRepository
    {
        string jsonFileName = @"Data\JsonBookings.json";

        public void AddBooking(Booking bk)
        {
            List<Booking> @bookings = GetAllBookings();
            List<int> bookingIds = new List<int>();
            foreach (var bok in bookings)
            {
                bookingIds.Add(bok.BookingId);
            }

            if (bookingIds.Count != 0)
            {
                int start = bookingIds.Max();
                bk.BookingId = start + 1;
            }
            else
            {
                bk.BookingId = 1;
            }
            @bookings.Add(bk);
            JsonFileWriter.WritetoJsonBookings(@bookings, jsonFileName);
        }

        public void DeleteBooking(Booking bk)
        {
            Booking bookingDelete = GetBooking(bk.BookingId);
            List<Booking> bookings = GetAllBookings();
            bookings.Remove(bookingDelete);
            JsonFileWriter.WritetoJsonBookings(bookings, jsonFileName);
        }

        public List<Booking> FilterBookings(string filter)
        {
            List<Booking> filterList = new List<Booking>();
            foreach (var bk in GetAllBookings())
            {
                if (bk.Name.Contains(filter) || bk.Description.Contains(filter))
                {
                    filterList.Add(bk);
                }
            }
            return filterList;
        }

        //Booking should have a UserID
        public List<Booking> GetAllBookingsByMember(Member member)
        {
            List<Booking> userBookings = new List<Booking>();
            foreach (var bok in GetAllBookings())
            {
                //userid - snak med Julie om hvad hun kalder den
                if (bok.UserId.Equals(member.ID))
                {
                    userBookings.Add(bok);
                }
            }
            return userBookings;
        }

        //admin function to get all users and their booking - Might need to implement in user and boat to get individual classes
        public List<Booking> GetAllBookings()
        {
            return JsonFileReader.ReadJsonBookings(jsonFileName);
        }

        public Booking GetBooking(int bookingId)
        {
            List<Booking> bookings = GetAllBookings();
            foreach (var bk in bookings)
            {
                if (bk.BookingId == bookingId)
                {
                    return bk;
                }
            }
            return new Booking();
        }

        public void UpdateBooking(Booking bk)
        {
            List<Booking> bookings = GetAllBookings();
            if (@bk != null)
            {
                foreach (Booking b in bookings)
                {
                    if (b.BookingId == bk.BookingId)
                    {
                        b.BookingId = bk.BookingId;
                        b.Name = bk.Name;
                        b.Description = bk.Description;
                        b.DateTime = bk.DateTime;
                    }
                }
                JsonFileWriter.WritetoJsonBookings(bookings, jsonFileName);
            }
        }
    }
}
