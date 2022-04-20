using AirBnb.Api;
using Reservations.Abstractions;

namespace Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationManager _manager;
        private readonly IAirBnBApi _api;

        public ReservationService(IReservationManager manager, IAirBnBApi api)
        {
            _manager = manager;
            _api = api;
        }

        public ReservationDTO MakeReservation(string userName)
        {
            Reservation reservation = _manager.AddReservation(userName);

            //This should not be done
            _api.MakeReservation(userName);

            return new ReservationDTO
            {
                Days = reservation.Days,
                StartDate = reservation.StartDate,
                Id = reservation.Id,
                Data = reservation.Data
            };
        }
    }
}
