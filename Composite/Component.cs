using System.Collections.Generic;

namespace Composite
{
    public abstract class Component
    {
        protected string _name;
        protected List<Component> _components;

        public Component(string name)
        {
            this._name = name;
            this._components = new List<Component>();
        }

        public abstract void Operation();

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

        public abstract Component GetChild(int index);
    }
}