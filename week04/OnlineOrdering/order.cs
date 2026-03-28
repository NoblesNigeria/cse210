using System;
using System.Collections.Generic;

public class Order
{
    public string OrderId;
    private List<Product> _products;
    public Customer _customer;

    public Order(string orderId, Customer customer)
    {
        OrderId = orderId;
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        // Shipping cost
        total += _customer.LivesInUSA() ? 5 : 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (var product in _products)
        {
            label += $"{product._productName} (ID: {product._productId})\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer._name}\n{_customer.Address.GetFullAddress()}";
    }
}