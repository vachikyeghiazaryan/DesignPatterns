using System;
using IteratorNS.Pattern;
using IteratorNS.Enumerator;

namespace IteratorNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("________ ITERATOR _______");
            Aggregate aggregate = new ConcreteAggregate();
            aggregate[0] = "a";
            aggregate[1] = "b";
            aggregate[2] = "c";
            Iterator i = aggregate.CreateIterator();

            for (object e = i.First(); !i.IsDone(); e = i.Next())
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("________ ENUMERATOR _______");

            Enumerable enumerable = new Enumerable();
            enumerable[0] = "a";
            enumerable[1] = "b";
            enumerable[2] = "c";

            IEnumerator enumerator = enumerable.GetEnumerator();

            Console.WriteLine("___ WHILE ___");

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            enumerator.Reset();

            Console.WriteLine("___ FOREACH ___");

            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }
        }
    }
}
