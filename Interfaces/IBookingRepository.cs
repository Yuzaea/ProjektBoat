using WebAppPrototype.Models;

namespace WebAppPrototype.Interfaces {
    public interface IBookingRepository {
        List<Booking> GetAllBookings();
        Booking GetBooking(int bookingId);
        void AddBooking(Booking bk);
        void UpdateBooking(Booking bk);
        void DeleteBooking(int bookingId);
        List<Booking> FilterBookings(string filter);
        List<Booking> GetAllBookingsByUser(string user);
    }
}
