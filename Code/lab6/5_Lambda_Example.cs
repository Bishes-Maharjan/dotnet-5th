// Lambda Expressions:
// A short, anonymous function written inline. Syntax: (parameters) => expression.
// Used heavily with LINQ and delegates.

using System;

class LambdaExample
{
    static void Main()
    {
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(5)); // 25

        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(3, 7)); // 10

        Action<string> greet = name =>
        {
            string msg = "Hello, " + name + "!";
            Console.WriteLine(msg);
        };
        greet("Bishes"); // Hello, Bishes!
    }
}
