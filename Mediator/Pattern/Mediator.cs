using System;

namespace Mediator.Pattern
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2.Notify(message);
            }
            else
            {
                Colleague1.Notify(message);
            }
        }
    }

    public abstract class Colleague
    {
        protected readonly Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            this._mediator = mediator;
        }

        public abstract void Notify(string message);
        public abstract void Send(string message);
    }

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator)
            : base(mediator) { }
        
        public override void Notify(string message)
        {
            Console.WriteLine(message);
        }

        public override void Send(string message)
        {
            _mediator.Send(message, this);
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator)
            : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine(message);
        }

        public override void Send(string message)
        {
            _mediator.Send(message, this);
        }
    }
}
