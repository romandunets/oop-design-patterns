using System;

namespace Mediator
{
    public interface IMediator
    {
        void Send(string message, Colleague colleague);
    }

    public class ConcreteMediator : IMediator
    {
        protected ConcreteColleague1 colleague1;
        protected ConcreteColleague2 colleague2;

        public ConcreteColleague1 Colleague1
        {
            set { colleague1 = value; }
        }

        public ConcreteColleague2 Colleague2
        {
            set { colleague2 = value; }
        }

        public void Send(string message, Colleague colleague)
        {
            if (colleague == colleague1)
            {
                colleague1.Notify(message);
            }
            else if (colleague == colleague2)
            {
                colleague2.Notify(message);
            }
        }
    }

    public abstract class Colleague
    {
        protected IMediator mediator;

        public Colleague(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(IMediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague 1 gets message: " + message);
        }
    }

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(IMediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague 2 gets message: " + message);
        }
    }
}
