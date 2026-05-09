using System;

class Program
{
    static void Main()
    {
        // Pattern 1
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j + " ");
            Console.WriteLine();
        }

        Console.WriteLine();

        // Pattern 2
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        Console.WriteLine();

        // Pattern 3
        for (int i = 5; i >= 1; i--)
        {
            for (int j = 5; j >= 6 - i; j--)
                Console.Write(j + " ");
            Console.WriteLine();
        }
    }
}