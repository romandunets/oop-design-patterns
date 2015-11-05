using System;
using System.Collections.Generic;

namespace Builder
{
    public class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    public class ConcreteBuilder1 : IBuilder
    {
        protected Product product = new Product();

        public void BuildPartA()
        {
            product.AddPart("Part A1");
        }

        public void BuildPartB()
        {
            product.AddPart("Part B1");
        }

        public Product GetResult()
        {
            return product;
        }
    }

    public class ConcreteBuilder2 : IBuilder
    {
        protected Product product = new Product();

        public void BuildPartA()
        {
            product.AddPart("Part A2");
        }

        public void BuildPartB()
        {
            product.AddPart("Part B2");
        }

        public Product GetResult()
        {
            return product;
        }
    }

    public class Product
    {
        protected List<String> Parts = new List<String>();

        public void AddPart(String partName)
        {
            Parts.Add(partName);
        }

        public void Show()
        {
            Console.WriteLine("Product parts: ");
            foreach (String part in Parts)
            {
                Console.WriteLine("\tPart: {0}", part);
            }
        }
    }
}
