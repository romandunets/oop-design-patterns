using System;
using System.Collections;

namespace FlyweightPattern
{
    public class Client
    {
        public void Launch()
        {
            int extrinsicState = 22;

            FlyweightFactory factory = new FlyweightFactory();

            IFlyweight flyweightA = factory.GetFlyweight("Flyweight A");
            IFlyweight flyweightB = factory.GetFlyweight("Flyweight B");
            IFlyweight flyweightC = factory.GetFlyweight("Flyweight C");

            flyweightA.Operation(--extrinsicState);
            flyweightB.Operation(--extrinsicState);
            flyweightC.Operation(--extrinsicState);
        }
    }
    public class FlyweightFactory
    {
        protected Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("Flyweight A", new ConcreteFlyweight1());
            flyweights.Add("Flyweight B", new ConcreteFlyweight2());
            flyweights.Add("Flyweight C", new ConcreteFlyweight2());
        }

        public IFlyweight GetFlyweight(string key)
        {
            return ((IFlyweight) flyweights[key]);
        }
    }

    public interface IFlyweight
    {
        void Operation(int extrinsicState);
    }

    class ConcreteFlyweight1 : IFlyweight
    {
        public void Operation(int extrinsicState)
        {
            Console.WriteLine("ConcreteFlyweight1: " + extrinsicState);
        }
    }

    class ConcreteFlyweight2 : IFlyweight
    {
        public void Operation(int extrinsicState)
        {
            Console.WriteLine("ConcreteFlyweight2: " + extrinsicState);
        }
    }
}
