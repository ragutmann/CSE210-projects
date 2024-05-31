public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsUSA()
    {
        return address.IsUSA();
    }

    public override string ToString()
    {
        return $"{name}\n{address}";
    }
}
