using System;

namespace Bridge.Example.WithoutBridge
{
    public abstract class Abstraction
    {
        public virtual void Operation()
        {
            // this code must be abstracted from here
            Console.WriteLine("Implementation logic");

            // this code must be moved to derived class
            Console.WriteLine("Abstraction logic");
        }
    }
}