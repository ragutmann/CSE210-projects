public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Other getters and setters as needed
}
