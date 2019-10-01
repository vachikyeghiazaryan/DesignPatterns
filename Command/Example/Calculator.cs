using Command.Example.Commands;

namespace Command.Example
{
    public class Calculator
    {
        private readonly AriphmeticUnit ariphmeticUnit;
        private readonly ControlUnit controlUnit;

        public Calculator()
        {
            ariphmeticUnit = new AriphmeticUnit();
            controlUnit = new ControlUnit();
        }
        private int Run(ICommand command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();

            return ariphmeticUnit.Register;
        }

        public int Add(int operand)
        {
            return Run(new AddCommand(ariphmeticUnit, operand));
        }

        public int Undo(int level)
        {
            controlUnit.Undo(level);

            return ariphmeticUnit.Register;
        }

        public int Redo(int level)
        {
            controlUnit.Redo(level);

            return ariphmeticUnit.Register;
        }
    }
}