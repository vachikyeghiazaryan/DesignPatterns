using System;

namespace Mediator.Example
{
    public class Shop : Colleague
    {
        public Shop(Mediator mediator)
            : base(mediator) { }

        public void SellKetchup(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            var msg = this.GetType().Name + " ketchup is sold.";
            Console.WriteLine(msg);

            _mediator.Send(msg, this);
        }
    }
}
