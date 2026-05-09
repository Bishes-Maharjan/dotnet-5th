// Delegate:
// A type-safe function pointer — it holds a reference to a method and lets you call it indirectly.
//
// Event:
// Built on top of a delegate. It is a notification mechanism where one class raises it
// and others listen and react. Common in UI and pub/sub patterns.

using System;

delegate int MathOperation(int a, int b);

class Button
{
    public delegate void ClickHandler(string message);
    public event ClickHandler OnClick;

    public required void Click()
    {
        OnClick?.Invoke("Button was clicked!");
    }
}

class DelegateEventsExample
{
    static int Add(int a, int b) => a + b;
    static int Multiply(int a, int b) => a * b;

    static void Main()
    {
        // Delegate
        MathOperation op = Add;
        Console.WriteLine(op(3, 4)); // 7

        op = Multiply;
        Console.WriteLine(op(3, 4)); // 12

        // Event
        Button btn = new Button();
        btn.OnClick += (msg) => Console.WriteLine(msg);
        btn.Click(); // Button was clicked!
    }
}
