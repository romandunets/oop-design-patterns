using System;
using Iterator;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();

            aggregate[0] = "Item 1";
            aggregate[1] = "Item 2";
            aggregate[2] = "Item 3";
            aggregate[3] = "Item 4";

            ConcreteIterator iterator = new ConcreteIterator(aggregate);

            object item = iterator.First();
            while (!iterator.IsEnd())
            {
                Console.WriteLine(item);
                item = iterator.Next();
            }

            Console.Read();
        }
    }
}
