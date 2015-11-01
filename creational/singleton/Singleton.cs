using System;

class Singleton
{
    private static readonly Singleton instance = new Singleton();

    public static Singleton Instance
    {
        get 
        {
            return instance;
        }
    }

    protected Singleton()
    { }
}