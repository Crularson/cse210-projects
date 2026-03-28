public class Customer
{
    private string _name;
    private Address _address;
    
    public bool InUS(Address address)
    {
        if (address.GetCountry() == "US")
        {
            return true;
        }
        return false;
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
}