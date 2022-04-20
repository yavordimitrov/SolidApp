using AirBnb.Api;
using Services;
using Reservations.Abstractions;
using Reservations.AirBnB;

namespace Modules
{
    public class ModuleRegistration
    {
        public static IReservationService GetServicveInstance()
        {
            IReservationManager manager = new AirBnBManager(new AirBnBApi());
            //IReservationManager manager = new BookingManager(new BookingApi());

            return new ReservationService(manager);
        }
    }
}
