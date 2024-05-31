public class Swimming : Activity
{
    private int Laps { get; set; }

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    public override string GetDistance()
    {
        return $"{Math.Round(Laps * 50 / 1000.0, 1)} km";
    }

    public override string GetSpeed()
    {
        return $"{Math.Round(Laps * 50 / 1000.0 / Duration * 60 * 60, 1)} kph";
    }

    public override string GetPace()
    {
        return $"{Math.Round(Duration / (Laps * 50 / 1000.0), 2)} min per km";
    }
}

