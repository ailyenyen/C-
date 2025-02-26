using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        if (year % 4 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} is not a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is a leap year");
            }
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }
}