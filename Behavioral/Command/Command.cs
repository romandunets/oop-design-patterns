using System;

namespace Command
{
    class Client
    {
        public void Launch()
        {
            Invoker invoker = new Invoker();
            invoker.Action();
        }
    }

    class Invoker
    {
        ICommand command;

        public void Action()
        {
            command = new ConcreteCommand();
            command.Execute();
        }
    }

    interface ICommand
    {
        void Execute();
    }

    class ConcreteCommand : ICommand
    {
        private Receiver receiver = new Receiver();
        private String state = "free";

        public String State
        {
            get { return this.state; }
        }

        public void Execute()
        {
            state = "busy";
            receiver.Action();
            state = "free";
        }
    }

    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Some action...");
        }
    }
}
