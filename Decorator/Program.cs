using Decorator.Example1;
using DecoratorClass = Decorator.Example1.Decorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            DecoratorClass decorator = new ConcreteDecoratorA();
            decorator.SetComponent(component);

            decorator.Operation();
        }
    }
}
