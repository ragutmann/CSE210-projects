public class Activity
{
    protected string Date { get; set; }
    protected int Duration { get; set; }

    public Activity(string date, int duration)
    {
        Date = date;
        Duration = duration;
    }

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

