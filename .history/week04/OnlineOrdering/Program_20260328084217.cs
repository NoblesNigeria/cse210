using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("10 Downing St", "London", "", "UK");

        // Customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Alice Brown", address2);

        // Products
        Product product1 = new Product("Laptop", "P001", 800, 1);
        Product product2 = new Product("Mouse", "P002", 20, 2);

        Product product3 = new Product("Phone", "P003", 500, 1);

        // Orders
        Order order1 = new Order("ORD001", customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order("ORD002", customer2);
        order2.AddProduct(product3);

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}