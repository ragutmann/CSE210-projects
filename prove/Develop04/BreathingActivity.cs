public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
        // Constructor chaining to the base class constructor
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine($"Follow the instructions to practice breathing exercises for {duration} seconds...");
        Console.WriteLine();

        DateTime startTime = DateTime.Now;

        Console.WriteLine($"Starting in 5 seconds...");

        // Show countdown with loading animation
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"\rStarting in {i} seconds |"); Thread.Sleep(250);
            Console.Write($"\rStarting in {i} seconds /"); Thread.Sleep(250);
            Console.Write($"\rStarting in {i} seconds -"); Thread.Sleep(250);
            Console.Write($"\rStarting in {i} seconds \\"); Thread.Sleep(250);
        }
        Console.WriteLine("\rStarting in 1 second ");
        Console.WriteLine();

        // Loop until the specified duration entered by user is reached
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3); // Count down 3 seconds
            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            ShowCountDown(3); // Count down 3 seconds
            Console.WriteLine();
        }

        Console.WriteLine("Well done!!");
        Console.WriteLine();
        DisplayEndingMessage();
        Console.WriteLine();

    }
}
