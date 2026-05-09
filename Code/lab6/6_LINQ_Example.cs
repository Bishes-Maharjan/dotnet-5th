// LINQ (Language Integrated Query):
// Lets you query collections (lists, arrays, databases) using SQL-like syntax
// directly in C#. Works seamlessly with lambda expressions.

using System;
using System.Collections.Generic;
using System.Linq;

class LINQExample
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Get even numbers greater than 4
        var result = numbers
            .Where(n => n % 2 == 0 && n > 4)
            .OrderByDescending(n => n)
            .ToList();

        foreach (var n in result)
            Console.WriteLine(n); // 10 8 6

        // LINQ on strings
        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "Anna" };

        var aNames = names
            .Where(n => n.StartsWith("A"))
            .Select(n => n.ToUpper())
            .ToList();

        foreach (var name in aNames)
            Console.WriteLine(name); // ALICE  ANNA
    }
}
