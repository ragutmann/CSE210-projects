using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 to quit.");

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        Console.WriteLine();

        //Computing the sum

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Computing the average

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        //Computing the sum

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max number is: {max}");
        Console.WriteLine();


    }
}