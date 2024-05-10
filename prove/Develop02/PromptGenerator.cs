using System;

namespace JournalApp
{
    class PromptGenerator
    {
        public string GenerateMainMenu()
        {
            return "1. Add Entry\n" +
                   "2. View All Entries\n" +
                   "3. Search Entries by Date\n" +
                   "4. Exit";
        }

        public string GenerateEntryPrompt()
        {
            return "Enter date (MM/DD/YYYY): ";
        }

        public string GenerateSearchPrompt()
        {
            return "Enter date to search (MM/DD/YYYY): ";
        }

        public DateTime GetDateFromUser()
        {
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Invalid date format. Please enter in MM/DD/YYYY format.");
            }
            return date;
        }

        public string GetContentFromUser()
        {
            Console.Write("Enter journal entry content: ");
            return Console.ReadLine();
        }
    }
}