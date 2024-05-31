using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running { Date = "03 Nov 2022", Duration = 30, Distance = 3.0 },
            new Running { Date = "03 Nov 2022", Duration = 30, Distance = 4.8 },
            new Cycling { Date = "03 Nov 2022", Duration = 30, Speed = 12 },
            new Swimming { Date = "03 Nov 2022", Duration = 30, Laps = 10 }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
