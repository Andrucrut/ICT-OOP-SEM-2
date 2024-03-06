namespace DefaultNamespace;

public class BookingManagementEntity
{
    public bool MakeBooking(User user, TravelPackage package);
    public bool CancelBooking(Booking booking);
}