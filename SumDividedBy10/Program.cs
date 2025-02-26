using System;

class Program
{
    static double SumDivisibleBy10(double n)
    {
        if (n < 10)
        {
            return 0;
        }
        else if (n % 10 == 0)
        {
            return n + SumDivisibleBy10(n - 10);
        }
        else
        {
            return SumDivisibleBy10(n - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter value of n: ");
        double n = double.Parse(Console.ReadLine());
        
        double sum = SumDivisibleBy10(n);
        
        Console.WriteLine($"Sum: {sum:F2}");
    }
}