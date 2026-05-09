using System;

public class Program
{
	public delegate void MyDelegate(int a, int b);

	public static void Add(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
	public static void Sub(int a, int b) => Console.WriteLine($"{a} - {b} = {a - b}");

	public static void Main(string[] args)
	{
		MyDelegate d = Add;
		d += Sub;

		d(10, 20);
	}
}