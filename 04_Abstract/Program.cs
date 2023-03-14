using System;

namespace Abstraction
{
    class Program
    {
        abstract class AbstractClass
        {
            public abstract void Method();
        }

        class ConcreteClass : AbstractClass
        {
            public override void Method()
            {
                Console.WriteLine("Abstract Implementation");
            }
        }

        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();

            instance.Method();

            Console.ReadKey();
        }
    }
}
