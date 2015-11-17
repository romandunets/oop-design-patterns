using System;
using Visitor;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            ObjectStructure objectStructure = new ObjectStructure();

            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());

            ConcreteVisitor1 concreteVisitor1 = new ConcreteVisitor1();
            ConcreteVisitor2 concreteVisitor2 = new ConcreteVisitor2();

            objectStructure.Accept(concreteVisitor1);
            objectStructure.Accept(concreteVisitor2);

            Console.Read();
        }
    }
}
