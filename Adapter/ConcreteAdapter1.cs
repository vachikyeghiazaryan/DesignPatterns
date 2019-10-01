using System;

namespace Adapter
{
    public class ConcreteAdapter1 : Adapter
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteAdapter1 Operation");
        }
    }
}