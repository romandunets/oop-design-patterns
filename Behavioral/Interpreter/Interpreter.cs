using System;

namespace Interpreter
{
    public class Context
    {
    }

    public interface IExpression
    {
        void Interpret(Context context);
    }

    public class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal Expression...");
        }
    }

    public class NonterminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal Expression...");
        }
    }
}
