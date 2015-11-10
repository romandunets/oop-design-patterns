using System;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler Successor { get; set; }
        void HandlerRequest(string request);
    }

    public class ConcreteHandler1 : IHandler
    {
        public IHandler Successor { get; set; }

        public void HandlerRequest(string request)
        {
            if (request.Contains("Question:"))
            {
                Console.WriteLine(request.Replace("Question:", ""));
            }
            else if (this.Successor != null)
            {
                this.Successor.HandlerRequest(request);
            }
        }
    }

    public class ConcreteHandler2 : IHandler
    {
        public IHandler Successor { get; set; }

        public void HandlerRequest(string request)
        {
            if (request.Contains("Answer:"))
            {
                Console.WriteLine(request.Replace("Answer:", ""));
            }
            else if (this.Successor != null)
            {
                this.Successor.HandlerRequest(request);
            }
        }
    }
}
