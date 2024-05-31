public class Cycling : Activity
{
    private int Speed { get; set; }

    public Cycling(string date, int duration, int speed) : base(date, duration)
    {
        Speed = speed;
    }

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


