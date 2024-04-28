using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine();

        {
            DisplayWelcome();
            Console.WriteLine();

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            Console.WriteLine();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);
            Console.WriteLine();

        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;

        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int userNumber2 = int.Parse (userNumber);

            return userNumber2;

        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;

        }

        static void DisplayResult(string name, int square)
        {
             Console.WriteLine($"{name}, the square of your favorite number is {square}");
        }

    }
}