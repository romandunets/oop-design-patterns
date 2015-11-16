using System;
using Strategy;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStrategyA());
            context.Execute();

            context.Strategy = new ConcreteStrategyB();
            context.Execute();

            Console.Read();
        }
    }
}
