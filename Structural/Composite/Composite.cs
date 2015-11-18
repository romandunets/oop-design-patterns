using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public abstract class Component
    {
        public string Id { get; set; }

        public Component(string id)
        {
            this.Id = id;
        }

        public abstract void doOperation();
    }

    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string id) : base(id)
        {
        }

        public void AddChild(Component component)
        {
            children.Add(component);
        }

        public void RemoveChild(Component component)
        {
            children.Remove(component);
        }

        public Component GetChild(int index)
        {
            return children[index];
        }

        public override void doOperation()
        {
            Console.WriteLine("Composite {0}:", Id);

            foreach (Component component in children)
            {
                component.doOperation();
            }
        }
    }

    public class Leaf : Component
    {
        public Leaf(string id) : base(id)
        {
        }

        public override void doOperation()
        {
            Console.WriteLine("Leaf {0}", Id);
        }
    }
}
