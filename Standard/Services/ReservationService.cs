using Reservations.Abstractions;

namespace Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationManager _manager;

        public ReservationService(IReservationManager manager)
        {
            _manager = manager;
        }

        public ReservationDTO MakeReservation(string userName)
        {
            Reservation reservation = _manager.AddReservation(userName);

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
