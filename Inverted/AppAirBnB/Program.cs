using AppAirBnB.Modules;
using Services;
using System;

namespace AppAirBnB
{
    class Program
    {
        static void Main(string[] args)
        {
            IReservationService service = ModuleRegistration.GetServicveInstance();

            ReservationDTO reservation = service.MakeReservation("yavor");

            Console.WriteLine($"Created: { reservation.Data}");
            Console.WriteLine($"days: { reservation.Days}");
            Console.WriteLine($"start date: { reservation.StartDate}");

            Console.ReadKey();
        }
    }
}
