using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Api
{
    public class BookingApi : IBookingApi
    {
        public ReservationDTO BookPlace(string username)
        {
            return new ReservationDTO
            {
                Description = $"Booking reservation for {username}",
                StartDate = DateTime.Now,
                Days = 3,
                Id = "2ZyZb2AB1DmvOn0hFo"
            };
        }
    }
}
