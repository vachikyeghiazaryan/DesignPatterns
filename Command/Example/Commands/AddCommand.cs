namespace Command.Example.Commands
{
    public class AddCommand : ICommand
    {
        private readonly AriphmeticUnit ariphmeticUnit;
        private readonly int operand;

        public AddCommand(AriphmeticUnit ariphmeticUnit, int operand)
        {
            this.ariphmeticUnit = ariphmeticUnit;
            this.operand = operand;
        }

        public void Execute()
        {
            ariphmeticUnit.Run('+', operand);
        }

        public void UnExecute()
        {
            ariphmeticUnit.Run('-', operand);
        }
    }
}