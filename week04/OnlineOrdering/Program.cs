using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("37B Luna St", "Idaho", "Utah", "USA");
        Customer customer1 = new Customer("Ejiroghene Omarayeirue", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("32inches Television", "B28", 642.59, 1));
        order1.AddProduct(new Product("Remote control", "B12", 25.50, 1));
        order1.AddProduct(new Product("Pair of baterries", "B101", 2.05, 8));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Address address2 = new Address("31B Ibrahim Odofin St", "Lekki", "Lagos", "USA");
        Customer customer2 = new Customer("Iruoghene Omarayeirue", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Cake mixer", "D04", 350.50, 2));
        order2.AddProduct(new Product("Jeans", "S012", 8.75, 10));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}
