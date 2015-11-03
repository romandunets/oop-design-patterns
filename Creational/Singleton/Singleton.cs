using System;

namespace Program
{
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
}