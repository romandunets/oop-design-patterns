using System;
using AdapterPattern;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();

            Console.Read();
        }
    }
}
