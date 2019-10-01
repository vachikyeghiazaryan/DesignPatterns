using System;

namespace Composite
{
    public class Composite : Component
    {
        public Composite(string name)
            : base(name) { }

        public override void Operation()
        {
            Console.WriteLine($"Composite {base._name}");

            base._components.ForEach(c => c.Operation());
        }

        public override void Add(Component component)
        {
            this._components.Add(component);
        }

        public override void Remove(Component component)
        {
            this._components.Remove(component);
        }

        public override Component GetChild(int index)
        {
            return this._components[index];
        }
    }
}