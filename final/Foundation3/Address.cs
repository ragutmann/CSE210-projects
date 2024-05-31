public class Address
{
    private string Street { get; set; }
    private string City { get; set; }
    private string State { get; set; }
    private string Zipcode { get; set; }

    public Address(string street, string city, string state, string zipcode)
    {
        Street = street;
        City = city;
        State = state;
        Zipcode = zipcode;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State}, {Zipcode}";
    }
}
