using System;

namespace Memento.Example
{
    public interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDate();
    }
}
