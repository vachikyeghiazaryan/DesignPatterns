using System;

namespace Command.Example
{
    public class AriphmeticUnit
    {
        public int Register { get; private set; }

        internal void Run(char operationCode, int operand)
        {
            switch (operationCode)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"The {operationCode} operationCode not implemented");
            }
        }
    }
}