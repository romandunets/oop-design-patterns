using System;
using Prototype;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            IPrototype prototype1 = new ConcretePrototype1("One");
            IPrototype clonePrototype1 = prototype1.Clone();

            IPrototype prototype2 = new ConcretePrototype1("Two");
            IPrototype clonePrototype2 = prototype2.Clone();

            Console.WriteLine("First prototype: {0}", prototype1.GetId());
            Console.WriteLine("First prototype copy: {0}", clonePrototype1.GetId());

            Console.WriteLine("First prototype: {0}", prototype2.GetId());
            Console.WriteLine("First prototype copy: {0}", clonePrototype2.GetId());
        }
    }
}