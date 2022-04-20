using Booking.Api;
using Reservations.Abstractions;

namespace Reservations.Booking
{
    public class BookingManager : IReservationManager
    {
        private readonly IBookingApi _bookingApi;

        public BookingManager(IBookingApi bookingApi)
        {
            _bookingApi = bookingApi;
        }
        public Reservation AddReservation(string userName)
        {
            var bookingReservation = _bookingApi.BookPlace(userName);

            return new Reservation()
            {
                Days = bookingReservation.Days,
                Id = bookingReservation.Id,
                StartDate = bookingReservation.StartDate,
                Data = bookingReservation.Description

            };
        }
    }
}
