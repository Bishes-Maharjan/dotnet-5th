using System;

class Program
{
    static void Main()
    {
        int i = 1;

        // Pattern 1
        do
        {
            int j = 1;
            do
            {
                Console.Write(j + " ");
                j++;
            } while (j <= i);

            Console.WriteLine();
            i++;
        } while (i <= 5);

        Console.WriteLine();

        // Pattern 2
        i = 5;
        do
        {
            int j = 1;
            do
            {
                Console.Write(i + " ");
                j++;
            } while (j <= i);

            Console.WriteLine();
            i--;
        } while (i >= 1);

        Console.WriteLine();

        // Pattern 3
        i = 5;
        do
        {
            int j = 5;
            do
            {
                Console.Write(j + " ");
                j--;
            } while (j >= 6 - i);

            Console.WriteLine();
            i--;
        } while (i >= 1);
    }
}