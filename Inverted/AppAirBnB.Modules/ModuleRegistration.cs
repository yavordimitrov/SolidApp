using AirBnb.Api;
using Services;
using Reservations.Abstractions;
using Reservations.AirBnB;

namespace AppAirBnB.Modules
{
    public class ModuleRegistration
    {
        public static IReservationService GetServicveInstance()
        {
            IReservationManager manager = new AirBnBManager(new AirBnBApi());

            return new ReservationService(manager);
        }
    }
}
