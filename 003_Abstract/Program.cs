using System;

namespace Abstraction
{
    class Program
    {
        abstract class AbstractClassA
        {
            public abstract void OperationA();
        }

        abstract class AbstractClassB : AbstractClassA
        {
            public abstract void OperationB();
        }
        class ConcreteClass : AbstractClassB
        {
            public override void OperationA()
            {
                Console.WriteLine("ConcreteClassA.OperationA");
            }

            public override void OperationB()
            {
                Console.WriteLine("ConcreteClassB.OperationB");
            }
        }

        static void Main(string[] args)
        {
            AbstractClassB instance = new ConcreteClass();

            instance.OperationA();
            instance.OperationB();

            Console.ReadKey();
        }
    }
}
