using System;
using Proxy;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Clinet client = new Clinet();
            client.Launch();

            Console.Read();
        }
    }
}
