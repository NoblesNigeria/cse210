public class Address
{
    private string _street;
    private string _city;
    private string _state;
    public string _country;

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsUSA()
    {
        return Country.ToLower() == "usa" || Country.ToLower() == "united states";
    }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}