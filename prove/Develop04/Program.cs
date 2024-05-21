using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine();

        var choice = "";
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine();
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                Console.WriteLine("Welcome to the Breathing Activity.");
                Console.WriteLine();
                BreathingActivity breathingActivity = new BreathingActivity(60); // Assuming 60 seconds duration for breathing activity
                breathingActivity.Run();
            }

            else if (choice == "2")
            {
                Console.WriteLine("Welcome to the Reflecting Activity.");
                Console.WriteLine();
                ReflectingActivity reflectingActivity = new ReflectingActivity(60); // Assuming 60 seconds duration for reflecting activity
                reflectingActivity.Run();
            }

            else if (choice == "3")
            {
                Console.WriteLine("Starting Listing Activity...");
                ListingActivity listingActivity = new ListingActivity(60); // Assuming 60 seconds duration for listing activity
                listingActivity.Run();
            }

            else if (choice == "4")
            {
                Console.WriteLine("Goodbye");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Invalid Choice. Try Again!");
                Console.WriteLine();
            }
            
        }
        while (choice != "4");

    }
}