using System;
class SwitchMenu {
    static void Main() {
        Console.Write("1.Add 2.Sub 3.Mul 4.Div\nChoice: ");
        int c = int.Parse(Console.ReadLine()!);
        Console.Write("Enter a b: ");
        double a = double.Parse(Console.ReadLine()!), b = double.Parse(Console.ReadLine()!);
        switch (c) {
            case 1: Console.WriteLine("Result: " + (a + b)); break;
            case 2: Console.WriteLine("Result: " + (a - b)); break;
            case 3: Console.WriteLine("Result: " + (a * b)); break;
            case 4: Console.WriteLine("Result: " + (b != 0 ? a / b : double.NaN)); break;
            default: Console.WriteLine("Invalid"); break;
        }
    }
}
