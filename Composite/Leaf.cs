using System;

namespace Composite
{
    public class Leaf : Component
    {
        public Leaf(string name)
            : base(name) { }

        public override void Add(Component component)
        {
            throw new InvalidOperationException();
        }

        public override Component GetChild(int index)
        {
            throw new InvalidOperationException();
        }

        public override void Operation()
        {
            Console.WriteLine($"Leaf {base._name}");
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException();
        }
    }
}