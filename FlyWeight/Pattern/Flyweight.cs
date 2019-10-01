using System.Collections;

namespace FlyWeight.Pattern
{
    /**
    * Flyweight
    * Type: Structural
    * What it is:
    * Use sharing to support large numbers of
    * fine grained objects efficiently.
     */
    public interface Flyweight
    {
        void Operation(int extrinicState);
    }

    public class ConcreteFlyweight : Flyweight
    {
        private int intrinsicState;
        public void Operation(int extrinicState)
        {
            intrinsicState = extrinicState;
        }
    }

    public class UnsharedConcreteFlyweight : Flyweight
    {
        private int allState;
        public void Operation(int extrinicState)
        {
            allState = extrinicState;
        }
    }

    public class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();
        public Flyweight GetFlyweight(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                switch (key)
                {
                    case "ConcreteFlyweight":
                        flyweights.Add(key, new ConcreteFlyweight());
                        break;
                    case "UnsharedConcreteFlyweight":
                        flyweights.Add(key, new UnsharedConcreteFlyweight());
                        break;
                }
            }
            return (Flyweight)flyweights[key];
        }
    }
}