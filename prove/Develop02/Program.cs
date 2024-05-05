using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine();

        int userOption = 0;
        //string input;
        while(userOption != 4 && userOption != 5)
        {
            Journal journal = new Journal();
            userOption = 0;
            Console.WriteLine("");
            Console.WriteLine("Please choose one of the following options for thisJournal:");
            Console.WriteLine("");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine(" ");
            Console.Write("What would you like to do? ");
            Console.WriteLine("");
            userOption = int.Parse(Console.ReadLine());

            if (userOption ==1)
            {
                //insert prompt here
                Console.Write("Your Response: ");
                string response = Console.ReadLine();
                journal.AddEntry(new Entry());
            }
            else if (userOption ==2)
            {
                journal.DisplayAll();
            }
            else if (userOption ==3)
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (userOption ==4)
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (userOption == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Input is invalid. Please insert pme of thefollowing numbers.");
            }
        }
    }
}
