using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.Api
{
    public class AirBnBApi : IAirBnBApi
    {
        public AirBnbReservationResponse MakeReservation(string userName)
        {
            return new AirBnbReservationResponse()
            {
                Details = $"Reservation from AirBnB for {userName}",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(3),
                Id = Guid.NewGuid()
            };
        }
    }
}
