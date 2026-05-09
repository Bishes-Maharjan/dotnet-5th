using System;

class Loops
{
    static void Main()
    {
        // i) For loop
        Console.WriteLine("=== For Loop ===");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("For loop iteration: " + i);
        }

        // ii) Foreach loop
        Console.WriteLine("\n=== Foreach Loop ===");
        string[] fruits = { "Apple", "Banana", "Cherry", "Mango" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }

        // iii) While loop
        Console.WriteLine("\n=== While Loop ===");
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine("While loop iteration: " + j);
            j++;
        }

        // iv) Do-While loop
        Console.WriteLine("\n=== Do-While Loop ===");
        int k = 1;
        do
        {
            Console.WriteLine("Do-While loop iteration: " + k);
            k++;
        } while (k <= 5);
    }
}
