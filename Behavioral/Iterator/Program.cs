using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();

            aggregate[0] = "Item A";
            aggregate[1] = "Item B";
            aggregate[2] = "Item C";
            aggregate[3] = "Item D";

            ConcreteIterator iterator = new ConcreteIterator(aggregate);

            Object item = iterator.First();

            while (item != null)
            {
                Console.WriteLine(item);
                item = iterator.Next();
            }
        }
    }

    interface IAggregate
    {
        IIterator CreateIterator();
        Int32 Count { get; }
        Object this[Int32 index] { get; set; }
    }

    class ConcreteAggregate : IAggregate
    {
        private readonly ArrayList items = new ArrayList();

        public Int32 Count
        {
            get { return this.items.Count; }
        }

        public Object this[Int32 index]
        {
            get { return this.items[index]; }
            set { items.Insert(index, value); }
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }

    interface IIterator
    {
        Object First();
        Object Next();
        Object Current();

        Boolean IsEnd();
    }

    class ConcreteIterator : IIterator
    {
        private readonly IAggregate aggregate;
        private Int32 current = 0;

        public ConcreteIterator(IAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public Object First()
        {
            return aggregate[0];
        }

        public Object Next()
        {
            object result = null;

            if (current < (aggregate.Count - 1))
            {
                result = aggregate[++current];
            }

            return result;
        }

        public Object Current()
        {
            return aggregate[current];
        }

        public Boolean IsEnd()
        {
            return current == aggregate.Count;
        }
    }
}
