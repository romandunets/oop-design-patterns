using System;
using Builder;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            IBuilder builder1 = new ConcreteBuilder1();
            IBuilder builder2 = new ConcreteBuilder2();

            director.Construct(builder1);
            Product product1 = builder1.GetResult();
            product1.Show();

            director.Construct(builder2);
            Product product2 = builder2.GetResult();
            product2.Show();

            Console.Read();
        }
    }
}
