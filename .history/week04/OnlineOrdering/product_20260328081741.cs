public class Product
{
    private string _name;
    public string ProductId { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }
}