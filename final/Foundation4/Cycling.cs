public class Cycling : Activity
{
    public int Speed { get; set; }

    public override string GetSpeed()
    {
        return $"{Speed} mph";
    }

    public override string GetDistance()
    {
        return $"{Math.Round(Speed * Duration / 60.0, 1)} miles";
    }

    public override string GetPace()
    {
        return $"{Math.Round(60.0 / Speed, 2)} min per mile";
    }
}

