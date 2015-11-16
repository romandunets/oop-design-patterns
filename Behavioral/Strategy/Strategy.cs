using System;

namespace Strategy
{
    public class Context
    {
        public IStrategy Strategy { get; set; }

        public Context(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public void Execute()
        {
            Strategy.BehaviorInterface();
        }
    }

    public interface IStrategy
    {
        void BehaviorInterface();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public void BehaviorInterface()
        {
            Console.WriteLine("Algorithm 1 is working...");
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void BehaviorInterface()
        {
            Console.WriteLine("Algorithm 2 is working...");
        }
    }
}
