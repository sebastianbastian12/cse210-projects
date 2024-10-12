using System;

public class Address{

    private string _street;
    private string _city;
    private string _state;
    private string _country;


    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool CustomerCountry(){
        return _country == "USA";
    }

    public string AddressDescription(){
        return $"{_street}\n{_city}, {_state}, {_country}";
    }


}