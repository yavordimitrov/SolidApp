namespace Reservations.Abstractions
{
    public interface IReservationManager
    {
        Reservation AddReservation(string userName);
    }
}
