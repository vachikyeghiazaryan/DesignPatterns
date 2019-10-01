using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento.Example
{
    public class Caretaker
    {
        private readonly List<IMemento> _mementos = new List<IMemento>();

        private readonly Originator _originator;

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");

            _mementos.Add(_originator.SaveState());
        }

        public void Undo()
        {
            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

            try
            {
                _originator.Restore(memento);
            }
            catch
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var item in _mementos)
            {
                Console.WriteLine(item.GetName());
            }
        }
    }
}
