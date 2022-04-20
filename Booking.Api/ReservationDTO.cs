using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Api
{
    public class ReservationDTO
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public int Days { get; set; }
        public string Description { get; set; }
    }
}
