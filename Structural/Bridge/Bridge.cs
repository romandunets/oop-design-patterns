using System;

namespace Bridge
{
    public class Abstraction
    {
        protected IImplementor implementor;

        public IImplementor Implementor
        {
            get { return implementor; }
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }

    public interface IImplementor
    {
        void Operation();
    }

    public class ConcreteImplementorA : IImplementor
    {
        public void Operation()
        {
            Console.WriteLine("Concrete operation A");
        }
    }

    public class ConcreteImplementorB : IImplementor
    {
        public void Operation()
        {
            Console.WriteLine("Concrete operation B");
        }
    }
}
