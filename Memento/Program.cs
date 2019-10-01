using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern");

            Pattern();

            Console.WriteLine();
            Console.WriteLine();

            Example();
        }

        static void Pattern()
        {
            var originator = new Pattern.Originator();
            originator.State = "ON";

            var caretaker = new Pattern.Caretaker();
            caretaker.Memento = originator.CreateMemento();
            originator.State = "OFF";

            originator.SetMemento(caretaker.Memento);

            Console.WriteLine(originator.State);
        }

        static void Example()
        {
            var originator = new Example.Originator("Originator's initial state");
            var caretaker = new Example.Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();
        }
    }
}
