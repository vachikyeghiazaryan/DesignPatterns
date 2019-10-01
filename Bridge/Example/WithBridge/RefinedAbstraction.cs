using System;

namespace Bridge.Example.WithBridge
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor implementor)
            : base(implementor)
        { }

        public override void Operation()
        {
            base.Operation();

            Console.WriteLine("Abstraction logic");
        }
    }
}