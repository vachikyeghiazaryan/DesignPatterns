using System;
using System.Threading;

namespace Memento.Example
{
    public class Originator
    {
        private string _state;

        public Originator(string state)
        {
            _state = state;
        }

        public void DoSomething()
        {
            _state = CreateRandomString(30);
        }

        private string CreateRandomString(int length)
        {
            var result = "";
            var allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var rnd = new Random();

            while (length-- > 0)
            {
                result += allowedChars[rnd.Next(0, allowedChars.Length - 1)];
                Thread.Sleep(11);
            }

            return result;
        }

        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new ArgumentException("Unknown memento class: " + memento.GetType().Name);
            }

            _state = memento.GetState();
        }

        public IMemento SaveState()
        {
            return new ConcreteMemento(_state);
        }
    }
}
