namespace DefaultNamespace;

public class PaymentEntity
{
    public string UserId { get; set; }
    public int[] ShoppingCartIds { get; set; } #состав нашего заказа
    public decimal PayableAmount { get; set; }
    public string PaymentMethod { get; set; }
    public DateTime PaymentDate { get; set; }
    public string Status { get; set; }
}