public class Running : Activity
{
    private double Distance { get; set; }

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

    public override string GetDistance()
    {
        return $"{Distance} miles";
    }

    public override string GetSpeed()
    {
        return $"{Math.Round(Distance / Duration * 60, 1)} mph";
    }

    public override string GetPace()
    {
        return $"{Math.Round(Duration / Distance, 2)} min per mile";
    }
}

