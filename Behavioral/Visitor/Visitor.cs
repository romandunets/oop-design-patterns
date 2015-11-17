using System;
using System.Collections.Generic;

namespace Visitor
{
    public interface IVisitor
    {
        void Visit(ConcreteElementA element);
        void Visit(ConcreteElementB element);
    }

    public class ConcreteVisitor1 : IVisitor
    {
        public void Visit(ConcreteElementA element)
        {
            Console.WriteLine("Visitor 1 is visiting {0}", element.GetType().Name);
        }

        public void Visit(ConcreteElementB element)
        {
            Console.WriteLine("Visitor 1 is visiting {0}", element.GetType().Name);
        }
    }

    public class ConcreteVisitor2 : IVisitor
    {
        public void Visit(ConcreteElementA element)
        {
            Console.WriteLine("Visitor 2 is visiting {0}", element.GetType().Name);
        }

        public void Visit(ConcreteElementB element)
        {
            Console.WriteLine("Visitor 2 is visiting {0}", element.GetType().Name);
        }
    }

    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class ObjectStructure
    {
        protected List<IElement> elements = new List<IElement>();

        public void Attach(IElement element)
        {
            elements.Add(element);
        }

        public void Detach(IElement element)
        {
            elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IElement element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
