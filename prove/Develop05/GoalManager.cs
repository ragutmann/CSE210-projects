using System;
using System.Collections.Generic;

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

        Goal goalToUpdate = _goals.Find(goal => goal._shortName.Equals(goalName));
        if (goalToUpdate != null)
        {
            int pointsEarned = goalToUpdate.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Event recorded for goal: {goalName}. You earned {pointsEarned} points.");
            DisplayPlayerInfo();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Goal not found.");
        }
    }

    private void LoadGoals()
    {
        Console.WriteLine("Enter the filename to load goals from:");
        string filename = Console.ReadLine();

        try
        {
            int totalPoints = 0; // Variable to store total points

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string type = line.Trim(); // Trim whitespace
                    string name = reader.ReadLine();
                    string description = reader.ReadLine();
                    int points = int.Parse(reader.ReadLine());
                    int target = int.Parse(reader.ReadLine());
                    int bonus = int.Parse(reader.ReadLine());

                    CreateGoal(type, name, description, points, target, bonus);
                    Console.WriteLine();
                    Console.WriteLine($"Goal \"{name}\" - Points Earned: {points}");
                    totalPoints += points; // Accumulate points
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Total points earned: {totalPoints}");
            Console.WriteLine();
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine();
            Console.WriteLine($"Error loading goals: {ex.Message}");
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
                    writer.WriteLine(goal.GetType().Name); // Write the type of the goal
                    writer.WriteLine(goal._shortName);
                    writer.WriteLine(goal._description);
                    writer.WriteLine(goal._points);

                    if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine(checklistGoal._target);
                        writer.WriteLine(checklistGoal._bonus);
                    }
                    else
                    {
                        writer.WriteLine("0"); // Placeholder for target
                        writer.WriteLine("0"); // Placeholder for bonus
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
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int target = 0;
        int bonus = 0;
        if (type.ToLower() == "checklist")
        {
            Console.WriteLine("Enter the target for the checklist goal:");
            target = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the bonus for the checklist goal:");
            bonus = int.Parse(Console.ReadLine());
        }

        switch (type.ToLower())
        {
            case "simple":
            case "eternal":
            case "checklist":
                Goal newGoal = null;
                if (type.ToLower() == "simple")
                {
                    newGoal = new SimpleGoal(name, description, points);
                }
                else if (type.ToLower() == "eternal")
                {
                    newGoal = new EternalGoal(name, description, points);
                }
                else if (type.ToLower() == "checklist")
                {
                    newGoal = new ChecklistGoal(name, description, points, target, bonus);
                }
                _goals.Add(newGoal);
                Console.WriteLine("Goal created successfully.");
                break;
            // default:
            //     Console.WriteLine("Invalid goal type.");
            //     break;
        }
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

    public void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        Console.WriteLine();
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal._shortName);
        }
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
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void RecordEvent(string goalName)
    {
        
        Goal goalToUpdate = _goals.Find(goal => goal._shortName.Equals(goalName));
        if (goalToUpdate != null)
        {
            int pointsEarned = goalToUpdate.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Event recorded for goal: {goalName}. You earned {pointsEarned} points.");
        }
        else
        {
            Console.WriteLine("\nGoal not found.");
        }
    Console.WriteLine();
    }

    // public void SaveGoals(string filename)
    // {
    //    try
    //     {
    //         using (StreamWriter writer = new StreamWriter(filename))
    //         {
    //             foreach (Goal goal in _goals)
    //             {
    //                 writer.WriteLine(goal.GetType().Name); // Write the type of the goal
    //                 writer.WriteLine(goal._shortName);
    //                 writer.WriteLine(goal._description);
    //                 writer.WriteLine(goal._points);

    //                 // If the goal is a ChecklistGoal, write target and bonus values
    //                 if (goal is ChecklistGoal checklistGoal)
    //                 {
    //                     writer.WriteLine(checklistGoal._target);
    //                     writer.WriteLine(checklistGoal._bonus);
    //                 }
    //                 else
    //                 {
    //                     // For other types of goals, write default values
    //                     writer.WriteLine("0"); // Placeholder for target
    //                     writer.WriteLine("0"); // Placeholder for bonus
    //                 }
    //             }
    //         }

    //         Console.WriteLine("Goals saved successfully.");
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine($"Error saving goals: {ex.Message}");
    //     }
    // }

    // public void LoadGoals(string filename)
    // {
    //     try
    //     {
    //         using (StreamReader reader = new StreamReader(filename))
    //         {
    //             string line;
    //             while ((line = reader.ReadLine()) != null)
    //             {
    //                 string type = line;
    //                 string name = reader.ReadLine();
    //                 string description = reader.ReadLine();
    //                 int points = int.Parse(reader.ReadLine());
    //                 int target = int.Parse(reader.ReadLine());
    //                 int bonus = int.Parse(reader.ReadLine());

    //                 CreateGoal(type, name, description, points, target, bonus);
    //             }
    //         }

    //         Console.WriteLine("Goals loaded successfully.");
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine($"Error loading goals: {ex.Message}");
    //     }
    // }
}
