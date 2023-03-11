using System;

namespace Nested
{
    class MyClass : BaseClass
    {
        private static string name;

        public static string Name
        {
            get => name;
            set => name = value;
        }

        // Nested class doesn't have methods from parent
        public static class Nested
        {
            static Nested()
            {
                Console.WriteLine(Name);
            }

            static void StaticMethod()
            {
                
            }
        }

        public void Method()
        {
            // AbstractMethod();
            Console.WriteLine("MyClass.Method");
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("MyClass.AbstractMethod");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            MyClass.Name = "MyClass";          

            myClass.Method();

            
        }
    }
}
