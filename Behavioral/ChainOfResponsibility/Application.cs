using System;
using ChainOfResponsibility;

namespace Application
{
    class Application
    {
        static void Main(string[] args)
        {
            IHandler handler = new ConcreteHandler1();
            handler.Successor = new ConcreteHandler2();

            handler.HandlerRequest("Question:What are you doing?");
            handler.HandlerRequest("Answer:Coding all the night.");

            Console.Read();
        }
    }
}