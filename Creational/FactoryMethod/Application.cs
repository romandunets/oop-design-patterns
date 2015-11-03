using System;
using FactoryMethod;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            AbstractCreator creatorA = new ConcreteCreatorA();
            IProduct productA = creatorA.FactoryMethod();
            productA.Launch();

            AbstractCreator creatorB = new ConcreteCreatorB();
            IProduct productB = creatorB.FactoryMethod();
            productB.Launch();

            Console.Read();
        }
    }
}
