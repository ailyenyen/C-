using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the principal amount: ");
        double amount = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the rate of interest: ");
        double rate = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the time in years: ");
        int years = int.Parse(Console.ReadLine());
        
        double simpleInterest = (amount * rate * years) / 100;
        
        Console.WriteLine($"The simple interest is: {simpleInterest}");
    }
}