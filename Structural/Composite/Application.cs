using System;
using CompositePattern;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");

            root.AddChild(new Leaf("Leaf 1-A"));

            Composite composite = new Composite("Composite 1-B");
            composite.AddChild(new Leaf("Leaf 2-A"));
            composite.AddChild(new Leaf("Leaf 2-B"));

            root.AddChild(composite);
            root.AddChild(new Leaf("Leaf 1-C"));

            root.doOperation();
            Console.Read();
        }
    }
}
