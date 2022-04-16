public class Order
{
    public Guid CustomerID { get; set; }
    public string Description { get; set; }
    public Decimal Price { get; set;}
    public int Quantity { get; set; }

}