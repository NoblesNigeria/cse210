public class Address
{
    private string _street;
    public string ity { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

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