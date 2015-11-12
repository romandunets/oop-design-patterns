using System;
using Command;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Launch();

            Console.Read();
        }
    }
}
