using System.Collections.Generic;

namespace Command.Pattern
{
    public abstract class Command
    {
        protected readonly List<Command> commands;
        
        protected readonly Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
           commands = new List<Command>();
        }

        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }

        public abstract void Execute();
    }
}