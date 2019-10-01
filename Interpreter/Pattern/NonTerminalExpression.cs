namespace Interpreter.Patterns
{
    public class NonTerminalExpression : AbstractExpression
    {
        AbstractExpression nonTerminalExpression;
        AbstractExpression terminalExpression;

        public override void Interpret(Context context)
        {
            if (context.Position < context.Source.Length)
            {
                terminalExpression = new TerminalExpression();
                terminalExpression.Interpret(context);
                context.Position++;

                if (context.Result)
                {
                    nonTerminalExpression = new NonTerminalExpression();
                    nonTerminalExpression.Interpret(context);
                }
            }
        }
    }
}
