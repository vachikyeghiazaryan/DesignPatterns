using System;
using Interpreter.Patterns;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context()
            {
                Source = "aaa",
                Vocabulary = 'a'
            };

            var nonTerminalExpression = new NonTerminalExpression();
            nonTerminalExpression.Interpret(context);
        }
    }
}
