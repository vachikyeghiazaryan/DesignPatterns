using System;

namespace Decorator.Example1
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete component operation");
        }
    }

    public abstract class Decorator : Component
    {
        protected Component _component;

        public void SetComponent(Component component)
        {
            this._component = component;
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteDecoratorA operation");

            if (_component != null)
            {
                _component.Operation();
            }
        }
    }
}