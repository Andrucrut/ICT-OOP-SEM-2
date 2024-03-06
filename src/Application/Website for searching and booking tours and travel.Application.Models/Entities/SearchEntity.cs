namespace DefaultNamespace;

public class SearchEntity
{
    public string Destination { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate{ get; set; }
    public int Duration { get; set; }
    public decimal Budget { get; set; }
    public List<Tour> SearchResults { get; set; }
}