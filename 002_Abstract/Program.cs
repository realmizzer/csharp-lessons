using System;

namespace Abstraction
{
    class Program
    {
        class ConcreteClassA
        { 
            public void Operation()
            {
                Console.WriteLine("ConcreteClassA.Operation");
            }
        }
        abstract class AbstractClass : ConcreteClassA
        {
            public abstract void Method();
        }
        class ConcreteClassB : AbstractClass
        {
            public override void Method()
            {
                Console.WriteLine("ConcreteClassBB.Method");
            }
        }
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClassB();

            instance.Operation();
            instance.Method();

            Console.ReadKey();
        }
    }
}
