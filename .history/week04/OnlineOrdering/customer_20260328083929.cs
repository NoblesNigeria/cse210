public class Customer
{
    p string _name;
    public Address Address;

    public Customer(string name, Address address)
    {
        _name = name;
        Address = address;
    }

    public bool LivesInUSA()
    {
        return Address.IsUSA();
    }
}