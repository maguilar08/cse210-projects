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

        if (fixingWriting == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // it doesn´t work
    // public void FullAddress()
    // {
    //     Console.WriteLine(_street);
    //     Console.WriteLine($"{_city}, {_state}");
    //     Console.WriteLine(_country);
    // }

    public string FullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}"; 
    }
}