using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Pattern
{
    public class Client
    {
        private readonly Invoker invoker;

        private readonly Receiver receiver;

        public Client()
        {
            invoker = new Invoker();
            receiver = new Receiver();
        }

        public void Action()
        {
            var command = new ConcreteCommand(receiver);
            invoker.StoreCommand(command);

            invoker.ExecuteCommand();
        }
    }
}
