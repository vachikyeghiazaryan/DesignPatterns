using System;
using System.Collections.Generic;

namespace Command.Pattern
{
    internal class Invoker
    {
        private Command command;

        internal void StoreCommand(Command command)
        {
            this.command = command;
        }

        internal void ExecuteCommand()
        {
            command.Execute();
        }
    }
}