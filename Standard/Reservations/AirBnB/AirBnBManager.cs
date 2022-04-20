using AirBnb.Api;
using Reservations.Abstractions;

namespace Reservations.AirBnB
{
    public class AirBnBManager : IReservationManager
    {

        private readonly IAirBnBApi _airBnBApi;

        public AirBnBManager(IAirBnBApi airBnBApi)
        {
            _airBnBApi = airBnBApi;
        }
        public Reservation AddReservation(string userName)
        {
            AirBnbReservationResponse airBnBReservation = _airBnBApi.MakeReservation(userName);

            return new Reservation()
            {
                Days = (airBnBReservation.EndDate - airBnBReservation.StartDate).Days,
                Id = airBnBReservation.Id.ToString(),
                StartDate = airBnBReservation.StartDate,
                Data = airBnBReservation.Details
            };
        }
    }
}
