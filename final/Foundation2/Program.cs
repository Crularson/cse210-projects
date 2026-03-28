using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Addresses
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "US");
        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Customers
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Customer cust2 = new Customer("Bob Smith", addr2);

        // Products
        Product p1 = new Product("Laptop", 101, 900, 1);
        Product p2 = new Product("Mouse", 102, 25, 2);
        Product p3 = new Product("Keyboard", 103, 45, 1);

        Product p4 = new Product("Monitor", 201, 200, 1);
        Product p5 = new Product("Desk Lamp", 202, 30, 1);

        // Orders
        Order order1 = new Order();
        Order order2 = new Order();

        order1.SetCustomer(cust1);
        order2.SetCustomer(cust2);

        // Add 2–3 products per order
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);

        order2.AddProduct(p4);
        order2.AddProduct(p5);

        // Display results for Order 1
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: {order1.Total()}");
        Console.WriteLine();

        // Display results for Order 2
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: {order2.Total()}");
    }
}