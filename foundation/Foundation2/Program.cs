using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        var address1 = new Address("905 Main St", "New York", "NY", "USA");
        var customer1 = new Customer("Smith Joseph", address1);
        var order1 = new Order(customer1);
        
        var product1 = new Product("Product1", "P101", 99.99, 1);
        var product2 = new Product("Product2", "P102", 255.50, 2);
        
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Displaying order details for the first order
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalPrice()}\n");

        // The second order
        var address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");
        var customer2 = new Customer("Jane Smith", address2);
        var order2 = new Order(customer2);
        
        var product3 = new Product("Product3", "P103", 49.99, 1);
        var product4 = new Product("Product4", "P104", 719.99, 1);
        
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Displaying order details for the second order
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalPrice()}\n");
    }
}