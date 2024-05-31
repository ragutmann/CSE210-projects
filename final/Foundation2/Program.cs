using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Address address3 = new Address("12 Church St", "Houston", "TX", "US");
        Customer customer3 = new Customer("Bill Lake", address3);

        Product product1 = new Product("Laptop", 1001, 999.99, 1);
        Product product2 = new Product("Mouse", 2002, 19.99, 2);
        Product product3 = new Product("CPU", 3044, 325, 1);
        Product product4 = new Product("Monitor", 4035, 500, 1);
        Product product5 = new Product("Keyboard", 1034, 50, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product5);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product1);

        Order order3 = new Order(customer3);
        order3.AddProduct(product3);
        order3.AddProduct(product2);
        order3.AddProduct(product4);
        order3.AddProduct(product5);



        Console.WriteLine();
        Console.WriteLine("Order #1");
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine("====================");        
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("====================");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine("> Total including shipping cost: $" + order1.TotalCost().ToString("N2"));

        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------------------------------");

        Console.WriteLine("\nOrder #2");
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine("===================="); 
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("====================");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine("> Total including shipping cost: $" + order2.TotalCost().ToString("N2"));

        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------------------------------");

        Console.WriteLine("\nOrder #3");
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        Console.WriteLine("===================="); 
        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("====================");
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine("> Total including shipping cost: $" + order3.TotalCost().ToString("N2"));

        Console.WriteLine();

    }
}
