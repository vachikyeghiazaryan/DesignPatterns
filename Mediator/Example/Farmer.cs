using System;

namespace Mediator.Example
{
    public class Farmer : Colleague
    {
        public Farmer(Mediator mediator)
            : base(mediator) { }

        public void GrowTomatoes()
        {
            var msg = this.GetType().Name + " tomato is grown.";
            Console.WriteLine(msg);

            _mediator.Send(msg, this);
        }
    }
}
