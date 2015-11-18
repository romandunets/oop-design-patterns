using System;
using DecoratorPattern;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            ConcreteComponent concreteComponent = new ConcreteComponent();
            ConcreteDecoratorA concreteDecoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB concreteDecoratorB = new ConcreteDecoratorB();

            concreteDecoratorA.Component = concreteComponent;
            concreteDecoratorB.Component = concreteDecoratorA;

            concreteDecoratorB.Operation();

            Console.Read();
        }
    }
}
