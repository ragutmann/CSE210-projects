using System;
using System.IO.Enumeration;
public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        Entry userEntry = new Entry();
        userEntry.GenerateDate();
        userEntry.GeneratePrompt();
        userEntry.GetResponse();
        _entries.Add(userEntry);
        
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter ("myFile.txt", true))
        {  
            if ("myFile.txt".EndsWith (".csv"))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                }
            }
            else
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date:{entry._date},{entry._promptText},{entry._entryText}");
                    outputFile.WriteLine($"Prompt:{entry._promptText}");
                    outputFile.WriteLine($"{entry._entryText}");
                    outputFile.WriteLine();
                }
            }
        }
    }
    
    public void LoadFromFile(string file)
    {
        if ("myFile.txt".EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines("myFile.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"{response}");
                Console.WriteLine();
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader("myFile.txt"))
            {
                String journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }
}