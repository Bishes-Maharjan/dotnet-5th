// ICollection:
// Extends IEnumerable. Adds the ability to know the Count, check if something
// exists (Contains), and Add/Remove items. But has no index access.

using System;
using System.Collections.Generic;

class ICollectionExample
{
    static void Main()
    {
        ICollection<string> names = new List<string>();
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");

        Console.WriteLine(names.Count);           // 3
        Console.WriteLine(names.Contains("Bob")); // True
        names.Remove("Bob");
        Console.WriteLine(names.Count);           // 2
    }
}
