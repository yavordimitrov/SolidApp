using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Api
{
    public interface IBookingApi
    {
        ReservationDTO BookPlace(string username);
    }
}
