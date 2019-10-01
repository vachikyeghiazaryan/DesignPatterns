using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyNS.Example
{
    public class Context
    {
        private readonly Strategy _strategy;

        private int[] _array = { 3, 5, 1, 2, 4 };

        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void Sort()
        {
            _strategy.Sort(ref _array);
        }

        public void PrintArray()
        {
            Console.WriteLine(string.Join(", ", _array));
        }
    }
}
