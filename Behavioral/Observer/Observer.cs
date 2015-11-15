using System;
using System.Collections.Generic;

namespace Observer
{
    public abstract class AbstractSubject
    {
        protected List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }

    public class ConcreteSubject : AbstractSubject
    {
        public string State { get; set; }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        protected string name;
        protected string state;
        public ConcreteSubject Subject { get; set; }

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.Subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            state = Subject.State;
            Console.WriteLine("Observer {0} has a new state: {1}", name, state);
        }
    }
}
