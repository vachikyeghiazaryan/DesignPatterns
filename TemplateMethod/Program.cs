using System;

namespace TemplateMethod
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
            Pattern.AbstractClass instance = new Pattern.ConcreteClass();

            instance.TemplateMethod();
        }

        static void Example()
        {
            var polandFlag = new Example.PolandFlag();

            polandFlag.Draw();

            Console.WriteLine();

            var ukraineFlag = new Example.UkraineFlag();

            ukraineFlag.Draw();
        }
    }
}
