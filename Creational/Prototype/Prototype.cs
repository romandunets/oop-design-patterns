using System;

namespace Prototype
{
    public interface IPrototype
    {
        String Id { get; set; }
        String GetId();
        IPrototype Clone();
    }

    public class ConcretePrototype1 : IPrototype
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

    public class ConcretePrototype2 : IPrototype
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
