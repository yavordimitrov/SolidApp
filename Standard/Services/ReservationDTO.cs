using System;

namespace Services
{
    public class ReservationDTO
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public int Days { get; set; }
        public string Data { get; set; }
    }
}
