using System;

namespace Nested
{
    class MyClass
    {
        private static string name;

        public static string Name
        {
            get => name;
            set => name = value;
        }

        public class Nested : BaseClass
        {
            static Nested()
            {
                Console.WriteLine(Name);
            }

            public override void AbstractMethod()
            {
                Console.WriteLine("BaseClass->Nested.AbstractMethod");
            }
        }

        public void Method()
        {
            // AbstractMethod();
            Console.WriteLine("MyClass.Method");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            MyClass.Name = "MyClass";          

            myClass.Method();

            MyClass.Nested nestedClass = new MyClass.Nested();

            nestedClass.AbstractMethod();
        }
    }
}
