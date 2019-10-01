
using Mediator.Pattern;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern();

            Console.WriteLine();

            Example();
        }


        static void Pattern()
        {
            var mediator = new ConcreteMediator();
            var colleague1 = new ConcreteColleague1(mediator);
            var colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("message 1");
            colleague2.Send("message 2");
        }

        static void Example()
        {
            var mediator = new Example.ConcreteMediator();
            var farmer = new Example.Farmer(mediator);
            var cannery = new Example.Cannery(mediator);
            var shop = new Example.Shop(mediator);

            mediator.Farmer = farmer;
            mediator.Cannery = cannery;
            mediator.Shop = shop;

            farmer.GrowTomatoes();
        }
    }
}
