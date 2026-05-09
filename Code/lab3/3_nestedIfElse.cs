using System;
class NestedIfElse {
    static void Main() {
        Console.Write("Enter marks: ");
        int m = int.Parse(Console.ReadLine()!);
        if (m >= 60) {
            if (m >= 80) Console.WriteLine("A Grade");
            else Console.WriteLine("B Grade");
        } else {
            if (m >= 40) Console.WriteLine("C Grade");
            else Console.WriteLine("Fail");
        }
    }
}
