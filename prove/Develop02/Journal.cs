// Journal.cs
using System;
using System.Collections.Generic;

namespace JournalApp
{
    class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(DateTime date, string content)
        {
            Entry entry = new Entry(date, content);
            entries.Add(entry);
        }

        public void ViewAllEntries()
        {
            Console.WriteLine("All Journal Entries:");
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void SearchByDate(DateTime date)
        {
            Console.WriteLine($"Entries for {date.ToShortDateString()}:");
            foreach (var entry in entries)
            {
                if (entry.Date.Date == date.Date)
                {
                    Console.WriteLine(entry);
                }
            }
        }
    }
}