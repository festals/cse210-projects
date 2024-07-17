public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customers;


    public Order(List<Product> products, Customer myCustomer )
    {
        _products = products;
        _customers = myCustomer;
    }

    public void DisplayTotalCost()
    {
        float totalPrice = 0;

        foreach(Product p in _products)
        {
            totalPrice += p.Price();
        }

        if(_customers.FromUsa() == true)
        {
            Console.WriteLine($"${totalPrice + 5}");
        }
        else
        {
            Console.WriteLine($"${totalPrice + 35}");
        }

    }

    public string DisplayPackingLabel()
    // list the name and product id of each product in the order
    {
        int quantity = 0;
        string name = "";
        string id = "";
        string packingLabel = "";

        foreach(Product p in _products)
        {
            quantity = p.GetQuantity();
            name = p.GetName();
            id = p.GetId();
            packingLabel += $"{quantity} {name},{id}\n";
        }
        return packingLabel;
    }

    public string DisplayShippingLabel()
    {
        string name = "";
        string strAddress = "";

        name = _customers.GetName();
        strAddress = _customers.GetStrAddress();
    
        return $"{name}\n {strAddress}";
    }
    
}
