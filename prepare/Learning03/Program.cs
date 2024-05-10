using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine();

        Fraction x = new Fraction();
        Console.WriteLine(x.GetFractionString()); // Display 1/1
        Console.WriteLine(x.GetDecimalValue()); //Display result of 1/1
        Console.WriteLine();

        Fraction x2 = new Fraction(5); // To change the numerator value to 5, 
        Console.WriteLine(x2.GetFractionString()); // to display 5/1
        Console.WriteLine(x2.GetDecimalValue()); // Display the result of 5/1
        Console.WriteLine();

        Fraction x3 = new Fraction(3, 4); // To change the numerator value to 3, and denominator to 4 
        Console.WriteLine(x3.GetFractionString()); // to display 3/4
        Console.WriteLine(x3.GetDecimalValue()); // Display the result of 3/4
        Console.WriteLine();

        Fraction x4 = new Fraction(1, 3); // To change the numerator value to 1, and denominator to 3
        Console.WriteLine(x4.GetFractionString()); // to display 1/3
        Console.WriteLine(x4.GetDecimalValue()); // Display the result of 3/4
        Console.WriteLine();

    }
}