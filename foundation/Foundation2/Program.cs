using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("9090 Project Drive", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("Giovanni Cardenas", address);
        List<Product> products1 = new List<Product>();
        Product product1 = new Product("Google Mini", 12345, 25, 2);
        products1.Add(product1);
        Product product2 = new Product("Google Nest", 12344, 50, 2);
        products1.Add(product2);
        Product product3 = new Product("65-inch Samsung TV", 12343, 300, 1);
        products1.Add(product3);
        Order order1 = new Order(products1,  customer1);
        
        address = new Address("1080 Hooper Lane", "VacationCity", "Cancoon", "MX");
        customer1 = new Customer("Rajon Rondo", address);
        List<Product> products2 = new List<Product>();
        product1 = new Product("Couch", 12411, 500, 1);
        products2.Add(product1);
        product2 = new Product("Mouse", 12412, 20, 1);
        products2.Add(product2);
        product3 = new Product("Lamp", 12413, 30, 2);
        products2.Add(product3);
        Order order2 = new Order(products2,  customer1);

        Console.Clear();
        Console.WriteLine(order1.GetDisplayPackingLabel());
        Console.WriteLine(order1.GetDisplayShippingLabel());
        Console.WriteLine(order1.DisplayTotalOrderCost());

        Console.WriteLine("\n");
        Console.WriteLine(order2.GetDisplayPackingLabel());
        Console.WriteLine(order2.GetDisplayShippingLabel());
        Console.WriteLine(order2.DisplayTotalOrderCost());
    }
}