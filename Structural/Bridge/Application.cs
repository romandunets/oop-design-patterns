using System;
using Bridge;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction();

            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();

            Console.Read();
        }
    }
}
