using System;

namespace AbstractFactory
{
    public class Client
    {
        protected IAbstractProductA productA;
        protected IAbstractProductB productB;

        public Client(IAbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }

        public void Launch()
        {
            productA.Launch();
            productB.Launch();
        }
    }

    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public interface IAbstractProductA
    {
        void Launch();
    }

    public class ProductA1 : IAbstractProductA
    {
        public void Launch()
        {
            Console.WriteLine("Launch ProductA1...");
        }
    }

    public class ProductA2 : IAbstractProductA
    {
        public void Launch()
        {
            Console.WriteLine("Launch ProductA2...");
        }
    }

    public interface IAbstractProductB
    {
        void Launch();
    }

    public class ProductB1 : IAbstractProductB
    {
        public void Launch()
        {
            Console.WriteLine("Launch ProductB1...");
        }
    }

    public class ProductB2 : IAbstractProductB
    {
        public void Launch()
        {
            Console.WriteLine("Launch ProductB2...");
        }
    }
}
