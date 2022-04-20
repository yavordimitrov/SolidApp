using AirBnb.Api;
using Services;
using Booking.Api;
using Reservations.Abstractions;
using Reservations.AirBnB;
using Reservations.Booking;

namespace App.Modules
{
    public class ModuleRegistration
    {
        public static IReservationService GetServicveInstance(string reservationProvider)
        {
            IReservationManager manager;
            if (reservationProvider == "AirBnB")
            {
                manager = new AirBnBManager(new AirBnBApi());
            }
            else
            {
                manager = new BookingManager(new BookingApi());
            }

            return new ReservationService(manager);
        }
    }
}
