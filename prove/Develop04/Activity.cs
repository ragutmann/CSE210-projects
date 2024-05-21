public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = 20;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name}: {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}...");
    }

    public void ShowSpinner(int seconds)
    {
         Console.Write("Processing ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // Sleep for 1 second
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        Console.WriteLine("Countdown:");
        for (int i = seconds; i >= 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000); // Sleep for 1 second
        }
    }



}