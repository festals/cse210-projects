using System.Reflection.Metadata.Ecma335;

public class Product
{
    private string _name;
    private string _productId;
    private float _price;  //per unit
    private int _quantity;  //of this product


    public Product(string name, string id, float price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }


    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public float Price()
    {
        return _price * _quantity;
    }
}