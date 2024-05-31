public class Running : Activity
{
    public double Distance { get; set; }

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
