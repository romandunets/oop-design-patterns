using System;

public abstract class AbstractFactory
{
    protected abstract IProduct CreateProduct();

    public IProduct FactoryMethod()
    {
        return this.CreateProduct();
    }
}

public class ConcreteFactory1 : AbstractFactory
{
    protected override IProduct CreateProduct()
    {
        return new ConcreteProduct1();
    }
}

public class ConcreteFactory2 : AbstractFactory
{
    protected override IProduct CreateProduct()
    {
        return new ConcreteProduct2();
    }
}

public interface IProduct
{
    void Launch();
}

public class ConcreteProduct1 : IProduct
{
    public void Launch()
    {
        Console.WriteLine("Launch Product 1");
    }
}

public class ConcreteProduct2 : IProduct
{
    public void Launch()
    {
        Console.WriteLine("Launch Product 2");
    }
}