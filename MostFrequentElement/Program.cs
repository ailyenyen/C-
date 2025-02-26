using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        
        Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        MostFrequent(array, size);
    }

    static void MostFrequent(int[] array, int size)
    {
        int[] newArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            newArray[i] = 0;
        }
        
        int mostFrequent = array[0];

        do
        {
            for (int i = 1; i < size; i++)
            {
                if (mostFrequent == array[i])
                {
                    newArray[i] += 1;
                }

                mostFrequent = array[i];
            }

        }while(mostFrequent != array[size - 1]);
        
        int max = newArray[0];
        int index = 0;

        for (int i = 1; i < size; i++)
        {
            if (max < newArray[i])
            {
                max = newArray[i];
                index = i;
            }
        }
        
        Console.WriteLine($"Most frequent element: {array[index]}");

    }
}