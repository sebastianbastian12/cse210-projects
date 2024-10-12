using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop ASUS", 145, 1200, 2);
        Product product2 = new Product("LG Smart TV", 148, 1350, 3);
        Address address1 = new Address("Street melburm 25", "Austin", "Texas", "USA");
        Customer customer1 = new Customer("Pepito Perez", address1);
        

        Order order1 = new Order();
        order1._Products.Add(product1);
        order1._Products.Add(product2);
        order1._Customers.Add(customer1);
        order1.TotalOrderCalculation();

        Product product3 = new Product("Apple Table", 150, 1800, 5);
        Product product4 = new Product("Smart Phone Samsung", 152, 1150, 1);
        Product product5 = new Product("Camera Cannon", 172, 1750, 2);
        Address address2 = new Address("Calle 76 sur", "Bogota", "Bogota D.C", "Colombia");
        Customer customer2 = new Customer("Seferino Lopez", address2);


        Order order2 = new Order();
        order2._Products.Add(product3);
        order2._Products.Add(product4);
        order2._Products.Add(product5);
        order2._Customers.Add(customer2);
        order2.TotalOrderCalculation();

    }
}