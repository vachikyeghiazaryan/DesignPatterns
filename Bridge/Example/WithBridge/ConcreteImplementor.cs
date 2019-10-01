using System;

namespace Bridge.Example.WithBridge
{
    public class ConcreteImplementor : Implementor
    {
        public override void OperationImpl()
        {
            Console.WriteLine("Implelentor logic");
        }
    }
}