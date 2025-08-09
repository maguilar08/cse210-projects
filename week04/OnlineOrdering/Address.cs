using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUsa()
    {
        string fixingWriting = _country.Trim();  //return _country.Trim().ToUpper() == "USA"; => This would be the short way...
        fixingWriting = fixingWriting.ToLower();

        if (fixingWriting == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void FullAddress()
    {
        Console.WriteLine(_street);
        Console.WriteLine($"{_city}, {_state}");
        Console.WriteLine(_country);
    }
}