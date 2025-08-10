using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // This won´t work because each variable must be declared and initialized before you use it.
        // Order order1 = new Order(Customer1);
        // Customer customer1 = new Customer("Joao", address1);
        // Address address1 = new Address("Calle Talizman PJE 17", "Cochabamba", "Cercado", "Bolivia");

        // This could be a solution to understand in a linear way
        // Order order1 = new Order(new Customer("Joao", new Address("Calle Talizman PJE 17", "Cochabamba", "Cercado", "Bolivia")));

        //just invert the first one
        //First 
        Address address1 = new Address("Calle Talizman PJE 17", "Cochabamba", "Cercado", "Bolivia");
        Customer customer1 = new Customer("Joao", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Smartphone", "P001", 859, 1));
        order1.AddProduct(new Product("Case", "P002", 30.99, 3));
        //Second
        Address address2 = new Address("Temple Square", "Salt Lake", "Utah", "USA");
        Customer customer2 = new Customer("Bishop Store", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Bible", "P101", 20.99, 50));
        order2.AddProduct(new Product("Rice", "P352", 58.99, 100));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotal()}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotal()}");
        





    }
}