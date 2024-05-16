using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("John", 3, 16);

        // Create a Scripture object
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, text);

        // Display the initial text and reference
        Console.WriteLine("\nReference: " + scripture.GetReference());
        Console.WriteLine("\nScripture Text:");
        Console.WriteLine(scripture.GetDisplayText());

        // Loop until all words are hidden or user types "quit"
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("\nProgram ended");
                break;
            }

            // Hide random words
            scripture.HideRandomWords(5);
            Console.WriteLine("\nScripture with Hidden Words:");
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program ended");
                break;
            }
        }
        Console.WriteLine();
    }
}
