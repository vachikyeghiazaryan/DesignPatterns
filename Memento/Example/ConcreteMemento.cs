using System;
namespace Memento.Example
{
    public class ConcreteMemento : IMemento
    {
        private string _state;
        private readonly DateTime _date;

        public ConcreteMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public string GetName()
        {
            return $"{this._date} / {_state.Substring(0, 6)}";
        }

        public string GetState()
        {
            return _state;
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }
}
