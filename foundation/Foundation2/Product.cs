using System;

public class Product {

    private string _productName;
    private int _productID;
    private int _productPrice;
    private int _productQuantity;

    public Product(string product, int producID, int productPrice, int productQuantity){

        _productName = product;
        _productID = producID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public int GetProductCost(){
        return _productQuantity * _productPrice;
    }

    public string GetPackingLabel(){
        return $"Product: {_productName}\nProduct ID: {_productID}\nProduct Price: ${_productPrice}\nProduct Quantity: {_productQuantity}\nTotal: ${_productPrice * _productQuantity}";
    }






}