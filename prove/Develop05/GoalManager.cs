using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        while (true)
        {
            DisplayMenu();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Quitting program...");
                    Console.WriteLine();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Enter the name of the goal for which you want to record an event:");
        string goalName = Console.ReadLine();
        Console.WriteLine();

        Goal goalToUpdate = _goals.Find(goal => goal.GetShortName().Equals(goalName, StringComparison.OrdinalIgnoreCase));
        if (goalToUpdate != null)
        {
            try
            {
                Console.WriteLine("Enter the points earned for the event:");
                int pointsEarned = int.Parse(Console.ReadLine());
                _score += pointsEarned;
                Console.WriteLine($"Event recorded for goal: {goalName}. You earned {pointsEarned} points.");
                DisplayPlayerInfo();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for points.");
            }
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    private void LoadGoals()
    {
        Console.WriteLine("Enter the filename to load goals from:");
        string filename = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filename) || !File.Exists(filename))
        {
            Console.WriteLine("Invalid file path.");
            return;
        }

        try
        {
            int totalPoints = 0;

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string type = line.Trim();
                    string name = reader.ReadLine();
                    string description = reader.ReadLine();
                    int points = int.Parse(reader.ReadLine());
                    int target = int.Parse(reader.ReadLine());
                    int bonus = int.Parse(reader.ReadLine());

                    CreateGoal(type, name, description, points, target, bonus);
                    Console.WriteLine();
                    Console.WriteLine($"Goal \"{name}\" - Points Earned: {points}");
                    totalPoints += points;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File not found: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save goals to:");
        string filename = Console.ReadLine();
        Console.WriteLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetType().Name);
                    writer.WriteLine(goal.GetShortName());
                    writer.WriteLine(goal.GetDescription());
                    writer.WriteLine(goal.GetPoints());

                    if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine(checklistGoal.GetTarget());
                        writer.WriteLine(checklistGoal.GetBonus());
                    }
                    else
                    {
                        writer.WriteLine("0");
                        writer.WriteLine("0");
                    }
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Enter the type of goal (Simple, Eternal, or Checklist):");
        string type = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Enter the description of the goal:");
        string description = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Enter the points for the goal:");
        int points = 0;
        if (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for points.");
            return;
        }
        Console.WriteLine();

        int target = 0;
        int bonus = 0;
        if (type.ToLower() == "checklist")
        {
            Console.WriteLine("Enter the target for the checklist goal:");
            int.TryParse(Console.ReadLine(), out target);
            Console.WriteLine();

            Console.WriteLine("Enter the bonus for the checklist goal:");
            int.TryParse(Console.ReadLine(), out bonus);
            Console.WriteLine();
        }

        CreateGoal(type, name, description, points, target, bonus);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Current Score: {_score}");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine();
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine();
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(string type, string name, string description, int points, int target = 0, int bonus = 0)
    {
        switch (type.ToLower())
        {
            case "simple":
                _goals.Add(new SimpleGoal(name, description, points));
                Console.WriteLine("Simple goal created successfully.");
                break;
            case "eternal":
                _goals.Add(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal goal created successfully.");
                break;
            case "checklist":
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                Console.WriteLine("Checklist goal created successfully.");
                break;
            // default:
            //     Console.WriteLine("Invalid goal type.");
            //     break;
        }
    }
}