using System;
using Interpreter;
using System.Collections.Generic;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            List<IExpression> expressions = new List<IExpression>();

            expressions.Add(new TerminalExpression());
            expressions.Add(new NonterminalExpression());
            expressions.Add(new TerminalExpression());
            expressions.Add(new TerminalExpression());

            foreach (IExpression expression in expressions)
            {
                expression.Interpret(context);
            }

            Console.Read();
        }
    }
}
