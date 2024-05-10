// Program.cs
using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

            // Adding sample entries
            myJournal.AddEntry(new DateTime(2024, 5, 7), "Today was a great day!");
            myJournal.AddEntry(new DateTime(2024, 5, 6), "Feeling a bit tired today.");
            myJournal.AddEntry(new DateTime(2024, 5, 5), "Started working on a new project.");

            Console.WriteLine("Welcome to Your Journal App!");

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n" + promptGenerator.GenerateMainMenu());
                Console.Write("Enter your choice: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                switch (choice)
                {
                    case 1:
                        Console.Write(promptGenerator.GenerateEntryPrompt());
                        DateTime date = promptGenerator.GetDateFromUser();
                        string content = promptGenerator.GetContentFromUser();
                        myJournal.AddEntry(date, content);
                        Console.WriteLine("Entry added successfully!");
                        break;
                    case 2:
                        myJournal.ViewAllEntries();
                        break;
                    case 3:
                        Console.Write(promptGenerator.GenerateSearchPrompt());
                        DateTime searchDate = promptGenerator.GetDateFromUser();
                        myJournal.SearchByDate(searchDate);
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
