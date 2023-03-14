using System;

namespace Abstraction
{
    class Program
    {
        abstract class AbstractClass
        {
            public AbstractClass()
            {
                Console.WriteLine("1 AbstractClass()");

                this.AbstractMethod();

                Console.WriteLine("2 AbstractClass()");
            }

            public abstract void AbstractMethod();
        }
        class ConcreteClass : AbstractClass
        {
            string s = "FIRST";

            public ConcreteClass()
            {
                Console.WriteLine("3 ConcreteClass");
                s = "SECOND";
            }

            public override void AbstractMethod()
            {
                Console.WriteLine("Реализация метода AbstractMethod() в ConcreteClass {0}", s);
            }
        }
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();

            instance.AbstractMethod();

            Console.ReadKey();
        }
    }
}
