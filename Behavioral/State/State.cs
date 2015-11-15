using System;

namespace State
{
    public interface IState
    {
        void Handle(Context context);
    }

    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }

    public class Context
    {
        public IState State { get; set; }

        public Context(IState state)
        {
            State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }

    interface IObject
    {
        void Stage1();
        void Stage2();
        void Stage3();
    }
}
