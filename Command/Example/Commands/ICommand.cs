namespace Command.Example.Commands
{
    public interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}