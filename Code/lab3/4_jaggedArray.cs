using System;
class JaggedArray {
    static void Main() {
        Console.Write("Enter rows: ");
        int r = int.Parse(Console.ReadLine()!);
        int[][] arr = new int[r][];
        for (int i = 0; i < r; i++) {
            Console.Write($"Cols in row {i+1}: ");
            int c = int.Parse(Console.ReadLine()!);
            arr[i] = new int[c];
            for (int j = 0; j < c; j++) {
                Console.Write($"[{i}][{j}]: ");
                arr[i][j] = int.Parse(Console.ReadLine()!);
            }
        }
        Console.WriteLine("Output:");
        foreach (var row in arr) { foreach (var v in row) Console.Write(v + " "); Console.WriteLine(); }
    }
}
