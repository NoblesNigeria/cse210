public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productIdroductId = productId;
        _price = price;
        _uantity = quantity;
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }
}