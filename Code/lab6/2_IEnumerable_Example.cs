// IEnumerable:
// The most basic collection interface. It only allows forward-only iteration
// over a collection using foreach. It has one method: GetEnumerator().

using System;
using System.Collections.Generic;

class IEnumerableExample
{
    static void Main()
    {
        IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        foreach (int n in numbers)
        {
            Console.WriteLine(n); // 1 2 3 4 5
        }
    }
}
