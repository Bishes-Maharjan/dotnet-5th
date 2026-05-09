using System;

class Matrix
{
    static void Main()
    {
        int[,] matrix = new int[2, 2];

        Console.WriteLine("Enter elements of a 2x2 matrix:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        Console.WriteLine("\nMatrix:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
