public class Activity
{
    public string Date { get; set; }
    public int Duration { get; set; }

    public virtual string GetDistance()
    {
        return "";
    }

    public virtual string GetSpeed()
    {
        return "";
    }

    public virtual string GetPace()
    {
        return "";
    }

    public virtual string GetSummary()
    {
        return $"{Date} - {GetType().Name} ({Duration} min): " +
               $"Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}
