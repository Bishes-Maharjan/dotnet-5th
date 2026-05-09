using System;

class Program
{
    static void Main()
    {
        int i = 1;

        // Pattern 1
        while (i <= 5)
        {
            int j = 1;
            while (j <= i)
            {
                Console.Write(j + " ");
                j++;
            }
            Console.WriteLine();
            i++;
        }

        Console.WriteLine();

        // Pattern 2
        i = 5;
        while (i >= 1)
        {
            int j = 1;
            while (j <= i)
            {
                Console.Write(i + " ");
                j++;
            }
            Console.WriteLine();
            i--;
        }

        Console.WriteLine();

        // Pattern 3
        i = 5;
        while (i >= 1)
        {
            int j = 5;
            while (j >= 6 - i)
            {
                Console.Write(j + " ");
                j--;
            }
            Console.WriteLine();
            i--;
        }
    }
}