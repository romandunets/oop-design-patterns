using System;
using FacadePattern;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.Operation1();
            facade.Operation2();
            facade.Operation3();

            Console.Read();
        }
    }
}
