using System;

namespace FactoryMethod
{
    public class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine($"concrete_product_{this.GetHashCode()}");
        }
    }
}