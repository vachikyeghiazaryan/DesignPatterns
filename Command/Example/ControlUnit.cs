using Command.Example.Commands;
using System.Collections.Generic;

namespace Command.Example
{
    public class ControlUnit
    {
        private readonly List<ICommand> commands = new List<ICommand>();
        private int current;

        internal void StoreCommand(ICommand command)
        {
            commands.Add(command);
        }

        internal void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }

        public void Undo(int level)
        {
            for (int i = 0; i < level; i++)
            {
                if (current > 0)
                {
                    commands[--current].UnExecute();
                }
            }
        }

        public void Redo(int level)
        {
            for (int i = 0; i < level; i++)
            {
                if (current < commands.Count - 1)
                {
                    commands[current++].Execute();
                }
            }
        }
    }
}