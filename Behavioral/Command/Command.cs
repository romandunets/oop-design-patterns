using System;

namespace Command
{
    public class Client
    {
        public void Launch()
        {
            Receiver receiver = new Receiver();
            AbstractCommand command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.command = command;
            invoker.Action();
        }
    }

    public class Invoker
    {
        public AbstractCommand command { get; set; }

        public void Action()
        {
            command.Execute();
        }
    }

    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Some action...");
        }
    }

    public class ConcreteCommand : AbstractCommand
    {
        protected string state = "free";

        public ConcreteCommand(Receiver receiver) : base(receiver)
        { }

        public string State
        {
            get { return this.state; }
        }

        public override void Execute()
        {
            state = "busy";
            receiver.Action();
            state = "free";
        }
    }

    public abstract class AbstractCommand
    {
        protected Receiver receiver;

        public AbstractCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
