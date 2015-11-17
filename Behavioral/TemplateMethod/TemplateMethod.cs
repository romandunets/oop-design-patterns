using System;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public void Launch()
        {
            Console.WriteLine("Launch:");
            this.PrimitiveOperation1();
            this.PrimitiveOperation2();
            this.PrimitiveOperation3();
        }

        protected virtual void PrimitiveOperation1()
        {
            Console.WriteLine("Primitive operation 1...");
        }

        protected virtual void PrimitiveOperation2()
        {
            Console.WriteLine("Primitive operation 2...");
        }

        protected virtual void PrimitiveOperation3()
        {
            Console.WriteLine("Primitive operation 3...");
        }
    }

    public class ConcreteClassA : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("Primitive operation 1-A...");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("Primitive operation 2-A...");
        }
    }

    public class ConcreteClassB : AbstractClass
    {
        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("Primitive operation 2-B...");
        }

        protected override void PrimitiveOperation3()
        {
            Console.WriteLine("Primitive operation 3-B...");
        }
    }
}
