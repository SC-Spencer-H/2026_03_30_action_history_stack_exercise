
internal class Program
{
    static void Main()
    {
        Stack<string> actionHistory = new Stack<string>();

        actionHistory.Push("Move Forward");
        actionHistory.Push("Open Chest");
        actionHistory.Push("Drink Potion");

        Console.WriteLine("Undoing Actions:");
        Console.WriteLine($"{actionHistory.Pop()} undone");
        Console.WriteLine($"{actionHistory.Pop()} undone");
        Console.WriteLine($"{actionHistory.Pop()} undone");
    }
}

// REFLECTION QUESTIONS
//
// 1) LIFO means Last In, First Out
// 2) An undo history uses a stack because you want to undo actions in order from most recent to least recent