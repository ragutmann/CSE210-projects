using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(int duration) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
        _prompts = new List<string>();
        _questions = new List<string>();
        InitializePrompts();
        InitializeQuestions();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"Follow the instructions to reflect for {duration} seconds...");
        Console.WriteLine();

        // Show countdown with loading animation before listing starts
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"\rStarting in {i} seconds |"); Thread.Sleep(250);
            Console.Write($"\rStarting in {i} seconds /"); Thread.Sleep(250);
            Console.Write($"\rStarting in {i} seconds -"); Thread.Sleep(250);
            Console.Write($"\rStarting in {i} seconds \\"); Thread.Sleep(250);
        }

        Console.WriteLine();
        DateTime startTime = DateTime.Now;

        // Loop until the specified duration entered by user is reached
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string prompt = GetRandomPrompt();
            string question = GetRandomQuestion();

            Console.WriteLine();
            Console.WriteLine($"---.{prompt}.---");
            Console.WriteLine();
            Console.WriteLine($"When you have something in mind, pess enter to continue.");
            Console.ReadLine();

            foreach (string q in _questions)
            {
                Console.WriteLine($"Question: {q}");
                ShowSpinner(5);
                Console.WriteLine();
            }
        }

        Console.WriteLine("Well done!!.");
        Console.WriteLine();
        DisplayEndingMessage();
        Console.WriteLine();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }

    private void InitializePrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }

    private void InitializeQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

}
