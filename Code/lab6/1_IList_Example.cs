// IList:
// An interface that represents an ordered, index-accessible collection.
// It extends ICollection and allows adding, removing, and accessing elements by index.

using System;
using System.Collections.Generic;

class IListExample
{
    static void Main()
    {
        IList<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Mango");

        Console.WriteLine(fruits[0]); // Apple
        fruits.RemoveAt(1);           // Removes Banana
        Console.WriteLine(fruits.Count); // 2
    }
}
