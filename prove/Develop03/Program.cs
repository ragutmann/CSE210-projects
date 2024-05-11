using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture(reference, scriptureText);

        // Display the complete scripture
        Console.Clear();
        scripture.GetDisplayText();

        while (true)
       {
           Console.WriteLine("Press enter to hide a word or type quit to exit:");
           string userInput = Console.ReadLine();


           if (userInput.ToLower() == "quit")
           {
               break;
           }
           else
           {
            Scripture scripture1 = new Scripture();
               Console.Clear();
               scripture1.HideRandomWords();
               scripture1.GetDisplayText();


               if (scripture.IsCompletelyHidden())
               {
                   Console.WriteLine("Congratulations, you have memorized the scripture!");
                   break;
               }
           }
       }
    }
}
