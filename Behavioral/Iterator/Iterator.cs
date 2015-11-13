using System;
using System.Collections;

namespace Iterator
{
    public interface IAggregate
    {
        IIterator CreateIterator();
        int Count { get; }
        object this[int index] { get; set; }
    }

    public class ConcreteAggregate : IAggregate
    {
        protected readonly ArrayList items = new ArrayList();

        public int Count
        {
            get { return items.Count; }
            protected set { }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }

    public interface IIterator
    {
        object First();
        object Next();
        object Current();
        bool IsEnd();
    }

    public class ConcreteIterator : IIterator
    {
        protected readonly IAggregate aggregate;
        protected int current = 0;

        public ConcreteIterator(IAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public object First()
        {
            return aggregate[0];
        }

        public object Next()
        {
            object element = null;

            if (++current < aggregate.Count)
            {
                element = aggregate[current];
            }

            return element;
        }

        public object Current()
        {
            return aggregate[current];
        }

        public bool IsEnd()
        {
            return current >= aggregate.Count;
        }
    }
}
