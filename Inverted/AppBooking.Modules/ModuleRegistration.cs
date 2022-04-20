using Services;
using Booking.Api;
using Reservations.Abstractions;
using Reservations.Booking;

namespace AppBooking.Modules
{
    public class ModuleRegistration
    {
        public static IReservationService GetServicveInstance()
        {
            IReservationManager manager = new BookingManager(new BookingApi());

            return new ReservationService(manager);
        }
    }
}
