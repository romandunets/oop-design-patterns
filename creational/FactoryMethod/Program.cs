using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory1 = new ConcreteFactory1();
            IProduct product1 = factory1.FactoryMethod();
            product1.Launch();

            AbstractFactory factory2 = new ConcreteFactory2();            
            IProduct product2 = factory2.FactoryMethod();
            product2.Launch();
        }
    }
}
