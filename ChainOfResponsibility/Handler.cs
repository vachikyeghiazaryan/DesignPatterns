using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Chain of Responsibility
    /// Type: Behavioral
    /// What it is:
    /// Avoid coupling the sender of a request to
    /// its receiver by giving more than one object
    /// a chance to handle the request.Chain the
    /// receiving objects and pass the request
    /// along the chain until an object handles it.
    /// </summary>
    public abstract class Handler
    {
        public Handler Successor { get; set; }

        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
            {
                Console.WriteLine("ConcreteHandler1 handle request");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 2)
            {
                Console.WriteLine("ConcreteHandler2 handle request");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}
