public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public string GetAddress()
    {
        return $@"{_street}
        {_city}
        {_stateOrProvince},{_country}";
    }
    public string GetCountry()
    {
        return _country;
    }
    public Address(string street, string city, string state, string country)
{
    _street = street;
    _city = city;
    _stateOrProvince = state;
    _country = country;
}
}