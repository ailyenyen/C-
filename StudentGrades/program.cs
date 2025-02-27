using System;

enum LetterGrade
{
    A, B, C, D, F
}

class Program
{
    
    static void Main()
    {
        Console.Write("Enter the number of grades to input: ");
        int size = int.Parse(Console.ReadLine());
        
        int[] grades = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter grade {i+1}: ");
            grades[i] = int.Parse(Console.ReadLine());
        }
        
        DisplayResults(grades);
    }

    static void DisplayResults(int[] grades)
    {
        double average = AverageGrade(grades);
        LetterGrade letter = GetLetterGrade(average);
        String status = GetStatus(letter);
        
        PrintGrades(grades);
        Console.WriteLine($"Average grade: {average:F2}");
        Console.WriteLine($"Letter grade: {letter}");
        FindMinMax(grades);
        Console.WriteLine($"Status: {status}");
    }

    static void PrintGrades(int[] grades)
    {
        Console.Write("\nGrades: ");

        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"{grades[i]} ");
        }
        Console.WriteLine();
    }

    static double AverageGrade(int[] grades)
    {
        int sum = 0;

        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        
        return (double) sum / grades.Length;
    }

    static LetterGrade GetLetterGrade(double n)
    {
        if (n <= 100.00 && n >= 90.00)
        {
            return LetterGrade.A;
        }
        else if (n <= 89.00 && n >= 80.00)
        {
            return LetterGrade.B;
        }
        else if (n <= 79.00 && n >= 70.00)
        {
            return LetterGrade.C;
        }
        else if (n <= 69.00 && n >= 60.00)
        {
            return LetterGrade.D;
        }
        else
        {
            return LetterGrade.F;
        }
    }

    static void FindMinMax(int[] grades)
    {
        int max = grades[0];
        int min = grades[0];

        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] > max)
            {
                max = grades[i];
            }
        }
        
        for (int j = 0; j < grades.Length; j++)
        {
            if (grades[j] < min)
            {
                min = grades[j];
            }
        }
        
        Console.WriteLine($"Lowest grade: {min}");
        Console.WriteLine($"Highest grade: {max}");
    }

    static String GetStatus(LetterGrade grade)
    {
        if (grade == LetterGrade.A || grade == LetterGrade.B || grade == LetterGrade.C || grade == LetterGrade.D)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }
}
