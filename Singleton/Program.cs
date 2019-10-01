using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            Console.WriteLine("instances are the same: {0}", ReferenceEquals(instance1, instance2));
        }
    }
}
