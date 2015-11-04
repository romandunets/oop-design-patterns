using System;
using AbstractFactory;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            IAbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Launch();

            IAbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Launch();

            Console.Read();
        }
    }
}
