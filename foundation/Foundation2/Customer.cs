using System;

public class Customer {

    private string _customerName;
    private Address _AddressClass;

    public Customer(string name, Address address){
        _customerName = name;
        _AddressClass = address;

    }

    public int GetCustomerAddressLocation(){
        return _AddressClass.CustomerCountry() ? 5:35;
    }

    public string GetCustomerName(){
        return $"Customer: {_customerName}";
    }

    public string GetShippingLabel(){
        return _AddressClass.AddressDescription();
    }
}