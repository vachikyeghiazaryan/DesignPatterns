using Command.Example;
using Command.Pattern;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RunPattern();

            Console.WriteLine(new string('-', 30));

            RunExample();
        }

        static void RunPattern()
        {
            var client = new Client();

            client.Action();
        }

        static void RunExample()
        {
            var calculator = new Calculator();

            var result = calculator.Add(5);

            Console.WriteLine("{0} = {1}", 5, result);

            result = calculator.Add(12);

            Console.WriteLine("{0} = {1}", 5 + 12, result);

            result = calculator.Undo(1);

            Console.WriteLine("{0} = {1}", 5, result);

            result = calculator.Redo(1);

            Console.WriteLine("{0} = {1}", 5 + 12, result);
        }
    }
}
