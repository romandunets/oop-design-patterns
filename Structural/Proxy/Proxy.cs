using System;

namespace Proxy
{
    public class Clinet
    {
        public void Launch()
        {
            ISubject subject = new Proxy();
            subject.DoOperation();
        }
    }

    public interface ISubject
    {
        void DoOperation();
    }

    public class RealSubject : ISubject
    {
        public void DoOperation()
        {
            Console.WriteLine("RealSubject operation...");
        }
    }

    public class Proxy : ISubject
    {
        protected RealSubject realSubject;

        public void DoOperation()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }

            realSubject.DoOperation();
        }
    }
}
