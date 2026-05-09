using System;
class JumpStatements {
    static void Main() {
        // goto
        int i = 1;
        start: if (i <= 3) { Console.WriteLine("goto: " + i++); goto start; }

        // break
        for (int j = 1; j <= 5; j++) {
            if (j == 4) { Console.WriteLine("break at " + j); break; }
            Console.WriteLine("break loop: " + j);
        }

        // continue
        for (int k = 1; k <= 5; k++) {
            if (k == 3) { continue; }
            Console.WriteLine("continue loop: " + k);
        }
    }
}
