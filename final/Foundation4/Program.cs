using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Running("03 Nov 2022", 90, 3.0),
            new Cycling("03 Nov 2022", 60, 15),
            new Swimming("03 Nov 2022", 30, 10)
        };

        Console.WriteLine();
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}
