using System;

namespace FacadePattern
{
    public class Facade
    {
        private SubSystemA subSystemA = new SubSystemA();
        private SubSystemB subSystemB = new SubSystemB();
        private SubSystemB subSystemC = new SubSystemB();

        public void Operation1()
        {
            Console.WriteLine("Operation 1:");
            subSystemA.Operation1();
            subSystemB.Operation1();
            subSystemC.Operation1();
        }

        public void Operation2()
        {
            Console.WriteLine("Operation 2:");
            subSystemA.Operation2();
            subSystemB.Operation2();
        }

        public void Operation3()
        {
            Console.WriteLine("Operation 3:");
            subSystemA.Operation3();
        }
    }

    public class SubSystemA
    {
        internal void Operation1()
        {
            Console.WriteLine("SubSystemA : Operation 1");
        }

        internal void Operation2()
        {
            Console.WriteLine("SubSystemA : Operation 2");
        }

        internal void Operation3()
        {
            Console.WriteLine("SubSystemA : Operation 3");
        }
    }

    public class SubSystemB
    {
        internal void Operation1()
        {
            Console.WriteLine("SubSystemB : Operation 1");
        }

        internal void Operation2()
        {
            Console.WriteLine("SubSystemB : Operation 2");
        }
    }

    public class SubSystemC
    {
        internal void Operation1()
        {
            Console.WriteLine("SubSystemC : Operation 1");
        }
    }
}
