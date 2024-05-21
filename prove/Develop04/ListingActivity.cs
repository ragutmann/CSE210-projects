using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(int duration) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _prompts = new List<string>();
        InitializePrompts();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine($"How long, in seconds, would you like for your session?");
        int _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();

        GetRandomPrompt();

        List<string> userResponses = GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {userResponses.Count} items.");

        Console.WriteLine();
        DisplayEndingMessage();
        Console.WriteLine();
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);

        Console.WriteLine($"---. {_prompts[index]} .---");
        Console.WriteLine();

        Console.WriteLine($"You have {_duration} seconds to think about the prompt before listing items.");
        Console.WriteLine();

        for (int i = 5; i > 0; i--)
        {
            Console.Write($"\rYou can start in {i} seconds |"); Thread.Sleep(250);
            Console.Write($"\rYou can start in {i} seconds /"); Thread.Sleep(250);
            Console.Write($"\rYou can start in {i} seconds -"); Thread.Sleep(250);
            Console.Write($"\rYou can start in {i} seconds \\"); Thread.Sleep(250);
        }

        Console.WriteLine();
        

    }

    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        DateTime startTime = DateTime.Now;

        Console.WriteLine();

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {

            Console.Write("Enter an item: ");
            string response = Console.ReadLine();
            userResponses.Add(response);
        }

        return userResponses;
    }

    private void InitializePrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
}
