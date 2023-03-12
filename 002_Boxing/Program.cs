using System;

namespace _001_Boxing
{
    interface IInterface
    {
        void Method();
    }

    struct MyStruct : IInterface
    {
        public void Method()
        {
            Console.WriteLine("MyStruct.Method");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct my;

            // Boxing
            IInterface obj = my;

            // Unboxing
            MyStruct my2 = (MyStruct)obj;

            my2.Method();

            Console.ReadKey();
        }
    }
}
