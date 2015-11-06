using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrototype prototype1 = new ConcretePrototype1("One");
            IPrototype clonePrototype1 = prototype1.Clone();

            IPrototype prototype2 = new ConcretePrototype1("Two");
            IPrototype clonePrototype2 = prototype2.Clone();

            Console.WriteLine("First prototype: {0}", prototype1.GetId());
            Console.WriteLine("First prototype copy: {0}", clonePrototype1.GetId());

            Console.WriteLine("First prototype: {0}", prototype2.GetId());
            Console.WriteLine("First prototype copy: {0}", clonePrototype2.GetId());
        }
    }

    interface IPrototype
    {
        String Id { get; set; }
        String GetId();
        IPrototype Clone();
    }

    class ConcretePrototype1 : IPrototype
    {
        public String Id { get; set; }

        public ConcretePrototype1(String id)
        {
            this.Id = id;
        }

        public String GetId()
        {
            return this.Id;
        }

        public IPrototype Clone()
        {
            return (IPrototype) this.MemberwiseClone();
        }
    }

    class ConcretePrototype2 : IPrototype
    {
        public String Id { get; set; }

        public ConcretePrototype2(String id)
        {
            this.Id = id;
        }

        public String GetId()
        {
            return this.Id;
        }

        public IPrototype Clone()
        {
            return (IPrototype) this.MemberwiseClone();
        }
    }
}
