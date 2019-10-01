using System;

namespace Mediator.Example
{
    public class Cannery : Colleague
    {
        public Cannery(Mediator mediator)
            : base(mediator) { }

        public void MakeKetchup(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            var msg = this.GetType().Name + " ketchup is made.";
            Console.WriteLine(msg);

            _mediator.Send(msg, this);
        }
    }
}
