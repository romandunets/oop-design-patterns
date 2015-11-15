using System;
using Memento;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "On";

            Console.WriteLine(originator.State);

            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            originator.State = "Off";

            Console.WriteLine(originator.State);

            originator.SetMemento(caretaker.Memento);

            Console.WriteLine(originator.State);
            Console.Read();
        }
    }
}
