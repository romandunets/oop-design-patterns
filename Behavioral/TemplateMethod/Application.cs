using System;
using TemplateMethod;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClass = new ConcreteClassA();
            abstractClass.Launch();

            abstractClass = new ConcreteClassB();
            abstractClass.Launch();

            Console.Read();
        }
    }
}
