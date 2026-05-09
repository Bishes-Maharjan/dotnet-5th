using System;

class Program
{
    static void Main()
    {
        int[] nums = {1,2,3,4,5};

        // Pattern 1
        foreach (int i in nums)
        {
            foreach (int j in nums)
            {
                if (j <= i)
                    Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Pattern 2
        foreach (int i in nums.Reverse())
        {
            foreach (int j in nums)
            {
                if (j <= i)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Pattern 3
        foreach (int i in nums.Reverse())
        {
            foreach (int j in nums.Reverse())
            {
                if (j >= 6 - i)
                    Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}