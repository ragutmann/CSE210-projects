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

        Console.WriteLine($"You have {_duration} seconds to list as many items as you can.");

        GetRandomPrompt();

        List<string> userResponses = GetListFromUser();

        Console.WriteLine($"You listed {userResponses.Count} items.");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        Console.WriteLine($"Prompt: {_prompts[index]}");
        Console.WriteLine($"You have {_duration} seconds to think about the prompt before listing items.");
        ShowCountDown(5); // Give 5 seconds countdown before listing items
    }

    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();
        DateTime startTime = DateTime.Now;

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
