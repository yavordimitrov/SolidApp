using System;

namespace Reservations.Abstractions
{
    public class Reservation
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public int Days { get; set; }
        public string Data { get; set; }
    }
}
