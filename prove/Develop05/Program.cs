using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine();

        // Create a GoalManager object
        // Call the start function on the object

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}