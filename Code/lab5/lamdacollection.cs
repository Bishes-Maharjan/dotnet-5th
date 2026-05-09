using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };

            Console.Write("The list: ");
            foreach (var value in numbers)
                Console.Write($"{value} ");
            Console.WriteLine();

            // Lambda to calculate square of each number
            var squares = numbers.Select(x => x * x);

            Console.Write("Squares: ");
            foreach (var value in squares)
                Console.Write($"{value} ");
            Console.WriteLine();

            // Lambda to find numbers divisible by 3
            var divisibleBy3 = numbers.FindAll(x => x % 3 == 0);

            Console.Write("Numbers Divisible by 3: ");
            foreach (var value in divisibleBy3)
                Console.Write($"{value} ");
            Console.WriteLine();
        }
    }
}