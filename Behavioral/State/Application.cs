using System;
using State;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStateA());

            Console.WriteLine(context.State);
            context.Request();
            Console.WriteLine(context.State);
            context.Request();
            Console.WriteLine(context.State);
            context.Request();
            Console.WriteLine(context.State);

            Console.Read();
        }
    }
}
