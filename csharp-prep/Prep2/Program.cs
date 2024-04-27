using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine();
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();

        Console.Write("What is your grade percentage? ");
        string userAnswerGradePercentage = Console.ReadLine();
        int gradePercent = int.Parse(userAnswerGradePercentage);

        string letterGrade = ""; 

        if (gradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");
        
        if (gradePercent >= 70)
        {
            Console.WriteLine("You passed the course");
        }
        else
        {
            Console.WriteLine("You did not passed the course");
        }
        Console.WriteLine();
    }
}