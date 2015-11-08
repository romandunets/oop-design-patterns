using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            IHandler handler = new ConcreteHandler1();
            handler.Successor = new ConcreteHandler2();

            handler.HandlerRequest("Question:What are You doing?");
            handler.HandlerRequest("Answer:Nothing interesting.");
        }
    }

    interface IHandler
    {
        IHandler Successor { get; set; }
        void HandlerRequest(String request);
    }

    class ConcreteHandler1 : IHandler
    {
        public IHandler Successor { get; set; }

        public void HandlerRequest(String request)
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

    class ConcreteHandler2 : IHandler
    {
        public IHandler Successor { get; set; }

        public void HandlerRequest(String request)
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