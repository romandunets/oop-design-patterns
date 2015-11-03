using Program;
using System;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            if (Object.ReferenceEquals(instance1, instance2))
            {
                Console.WriteLine("Both refereces links to one object");
            }
            Console.Read();
        }
    }
}
