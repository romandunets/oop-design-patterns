using System;

namespace Memento
{
    public class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return (new Memento(State));
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }

    public class Memento
    {
        public string State { get; protected set; }

        public Memento(string state)
        {
            this.State = state;
        }
    }

    public class Caretaker
    {
        protected Memento memento;

        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
