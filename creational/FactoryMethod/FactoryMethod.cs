using System;

public abstract class AbstractCreator
{
    protected abstract IProduct CreateProduct();

    public IProduct FactoryMethod()
    {
        return this.CreateProduct();
    }
}

public class ConcreteCreatorA : AbstractCreator
{
    protected override IProduct CreateProduct()
    {
        return new ConcreteProductA();
    }
}

public class ConcreteCreatorB : AbstractCreator
{
    protected override IProduct CreateProduct()
    {
        return new ConcreteProductB();
    }
}

public interface IProduct
{
    void Launch();
}

public class ConcreteProductA : IProduct
{
    public void Launch()
    {
        Console.WriteLine("Launch Product A");
    }
}

public class ConcreteProductB : IProduct
{
    public void Launch()
    {
        Console.WriteLine("Launch Product B");
    }
}