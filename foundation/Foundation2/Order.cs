using System;

public class Order{

    public List<Product> _Products = new List<Product>();
    public List<Customer> _Customers = new List<Customer>();

    public Order(){

    }

    public void TotalOrderCalculation(){

        int totalPrice = 0;

        foreach (var customer in _Customers)
        {
            totalPrice += customer.GetCustomerAddressLocation();
            Console.WriteLine($"{customer.GetCustomerName()}");
            Console.WriteLine($"Shipping Address: {customer.GetShippingLabel()}");
        }

        foreach (var product in _Products)
        {
            Console.WriteLine(product.GetPackingLabel());
            totalPrice += product.GetProductCost();
        }

        Console.WriteLine($"Total price plus shipping cost: ${totalPrice}");
        Console.WriteLine();
    }
}