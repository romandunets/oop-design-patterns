using System;
using Observer;

namespace Observer
{
    class Application
    {
        static void Main(string[] args)
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();

            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Observer A"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Observer B"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Observer C"));

            concreteSubject.State = "Loading...";
            concreteSubject.Notify();

            Console.Read();
        }
    }
}
