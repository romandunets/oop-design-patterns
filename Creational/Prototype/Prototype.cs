using System;

namespace Prototype
{
    public abstract class AbstractPrototype
    {
        protected string id;

        public AbstractPrototype(string id)
        {
            this.id = id;
        }

        public string GetId()
        {
            return this.id;
        }

        public abstract AbstractPrototype Clone();
    }

    public class ConcretePrototype1 : AbstractPrototype
    {
        public ConcretePrototype1(String id) : base(id)
        { }

        public override AbstractPrototype Clone()
        {
            return (AbstractPrototype) this.MemberwiseClone();
        }
    }

    public class ConcretePrototype2 : AbstractPrototype
    {
        public ConcretePrototype2(String id) : base(id)
        { }

        public override AbstractPrototype Clone()
        {
            return (AbstractPrototype) this.MemberwiseClone();
        }
    }
}
