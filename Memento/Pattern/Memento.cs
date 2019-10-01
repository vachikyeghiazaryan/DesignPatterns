using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Pattern
{
    public class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
    }

    public class Memento
    {
        public string State { get; private set; }

        public Memento(string state)
        {
            State = state;
        }
    }

    public class Caretaker
    {
        public Memento Memento { get; set; }
    }
}
