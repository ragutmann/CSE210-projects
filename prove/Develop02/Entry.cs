// Entry.cs
using System;

namespace JournalApp
{
    class Entry
    {
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public Entry(DateTime date, string content)
        {
            Date = date;
            Content = content;
        }

        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()}\nContent: {Content}\n";
        }
    }
}