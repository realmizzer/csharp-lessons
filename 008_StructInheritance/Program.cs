using System;

namespace Structure
{
    interface IInterface
    {
        void Method();
    }

    // Structures implements interfaces
    // and can't be extended by other structues or classes.
    struct MyStruct : IInterface // : ValueType
    {
        // Struct can't has protected fields and methods
        // protected int value;

        public void Method()
        {
            Console.WriteLine("MyStruct.Method");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct;

            myStruct.Method();

            Console.ReadKey();

        }
    }
}
