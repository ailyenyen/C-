using System;

class Program
{
    static void Main()
    {
        int total = 10;
        
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("Nothing happened");
        }
        else if (n > 0)
        {
            if (n % 2 == 0)
            {
                total += (n*n);
            }
            else
            {
                total += (n*n*n);
            }
        }
        else if (n < 0)
        {
            Console.Write("Enter another integer as an exponent: ");
            int x = int.Parse(Console.ReadLine());
            
            int partial = (int) Math.Pow(n, x);
            total += partial;
        }
        Console.WriteLine(total);
    }
}