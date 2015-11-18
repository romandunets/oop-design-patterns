using System;

namespace DecoratorPattern
{
    public interface IComponent
    {
        void Operation();
    }

    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Concrete operation...");
        }
    }

    public abstract class Decorator : IComponent
    {
        public IComponent Component { get; set; }

        public virtual void Operation()
        {
            if (Component != null)
            {
                Component.Operation();
            }
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Extended operation 1...");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Extended operation 2...");
        }
    }
}
