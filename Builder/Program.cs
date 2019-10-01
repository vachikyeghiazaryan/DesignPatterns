using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();
            Foreman foreman = new Foreman(builder);

            foreman.Construct();

            House house = builder.GetResult();

            Console.ReadKey();
        }
    }
}
