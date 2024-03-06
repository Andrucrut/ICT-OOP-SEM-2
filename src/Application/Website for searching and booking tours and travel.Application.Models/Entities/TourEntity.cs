namespace DefaultNamespace;

public class TourEntityEntity
{
    public int TourId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Destination { get; set; }
    public DateTime StartDate { get; set; }
    public int Duration { get; set; }
    public decimal Price { get; set; }
    public List<Review> Reviews { get; set; }
    public double Rating { get; set; }
}