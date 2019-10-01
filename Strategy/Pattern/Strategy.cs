using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyNS.Pattern
{
    public class Context
    {
        private readonly Strategy _strategy;

        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }

    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyA");
        }
    }

    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyB");
        }
    }

    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("ConcreteStrategyC");
        }
    }
}
