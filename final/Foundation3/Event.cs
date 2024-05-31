public class Event
{
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected string Date { get; set; }
    protected string Time { get; set; }
    protected Address Address { get; set; }

    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {Title}, Date: {Date}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
}

