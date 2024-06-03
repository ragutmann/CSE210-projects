using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Elm St", "Sometown", "NY", "67890");

        // Create events
        Event lectureEvent = new Lecture("Introduction to Python", "Learn the basics of Python programming", "2024-06-01", "10:00 AM", address1, "John Smith", 50);
        Event receptionEvent = new Reception("Networking Mixer", "Meet professionals in your industry", "2024-06-02", "6:00 PM", address2, "rsvp@example.com");
        Event outdoorEvent = new OutdoorGathering("Summer BBQ", "Enjoy food and games in the sun", "2024-06-03", "1:00 PM", address1, "Sunny");

        // Generate messages
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Console.WriteLine("==============================================================");
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine("==============================================================");
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Descriptions:");
        Console.WriteLine("==============================================================");
        Console.WriteLine();
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.GetShortDescription());
        Console.WriteLine();
    }
}
