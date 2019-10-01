using System;

namespace StrategyNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern();

            Console.WriteLine();

            Example();
        }

        static void Pattern()
        {
            var context = new Pattern.Context(new Pattern.ConcreteStrategyA());
            context.ContextInterface();

            context = new Pattern.Context(new Pattern.ConcreteStrategyB());
            context.ContextInterface();

            context = new Pattern.Context(new Pattern.ConcreteStrategyC());
            context.ContextInterface();
        }

        static void Example()
        {
            var context = new Example.Context(new Example.BubbleSort());

            context.PrintArray();
            context.Sort();
            context.PrintArray();
        }
    }
}
