using System;
using Prototype;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            AbstractPrototype prototype1 = new ConcretePrototype1("One");
            AbstractPrototype clonePrototype1 = prototype1.Clone();

            AbstractPrototype prototype2 = new ConcretePrototype1("Two");
            AbstractPrototype clonePrototype2 = prototype2.Clone();

            Console.WriteLine("First prototype: {0}", prototype1.GetId());
            Console.WriteLine("First prototype copy: {0}", clonePrototype1.GetId());

            Console.WriteLine("Second prototype: {0}", prototype2.GetId());
            Console.WriteLine("Second prototype copy: {0}", clonePrototype2.GetId());

            Console.Read();
        }
    }
}