using System;

namespace Static
{
    internal class NonStaticClass
    {
        private static int field;

        public static int Property
        {
            get => field;
            set => field = value;
        }

        static NonStaticClass()
        {
            Console.WriteLine("Static Constructor - NonStaticClass()");
            field = 1;
        }

        public NonStaticClass()
        {
            Console.WriteLine("Non Static constructor - NonStaticClass()");
        }

        public static void Method()
        {
            Console.WriteLine("Static method non static class");
        }

        public static void Method(int s)
        {
            Console.WriteLine("Overloaded Method in Non Static Class " + s);
        }

        public void NonStaticMethod()
        {
            Console.WriteLine(field);
        }
    }
}
