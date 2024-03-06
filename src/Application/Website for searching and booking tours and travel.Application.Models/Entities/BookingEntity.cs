namespace DefaultNamespace;

public class BookingEntity
{
    public int BookingId { get; set; }
    public TravelPackage Package { get; set; }
    public DateTime BookingDate { get; set; }
    public string Status { get; set; }
    public List<Payment> Payments { get; set; }
}