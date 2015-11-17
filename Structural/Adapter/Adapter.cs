using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Target request");
        }
    }

    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Specific request");
        }
    }
}
