public class Customer
{
    private string _name;
    private Address _addr;

    public Customer(string name, Address myAddress)
    {
        _name = name;
        _addr = myAddress;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetStrAddress()
    {
        return _addr.DisplayAddress();
    }

    public bool FromUsa()
    {
        return _addr.InUsa();
    }

}