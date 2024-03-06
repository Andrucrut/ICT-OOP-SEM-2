namespace DefaultNamespace;

public class ShoppingCart_Entity
{
    public string Id { get; set; } #создаем хэшфункцией
    public int UserId { get; set; }
    public int TravelPackageId { get; set; }
    public int AmountOfPackages { get; set; }
}