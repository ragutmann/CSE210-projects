using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();

        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int magicNumber2 = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int magicNumber2 = randomGenerator.Next(1, 100);
        Console.WriteLine($"The magic number is (randomly selected 1 to 100): {magicNumber2}");
        Console.WriteLine();

        int userGuess2 = 0;

        while (userGuess2 != magicNumber2)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            userGuess2 = int.Parse(userGuess);

            Console.WriteLine();
            if (userGuess2 == magicNumber2)
            {
                Console.WriteLine("You guessed the number!.");
            }
            else if (userGuess2 < magicNumber2)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess2 > magicNumber2)
            {
                Console.WriteLine("Lower");
            }
            Console.WriteLine();

        }
      
    }
}