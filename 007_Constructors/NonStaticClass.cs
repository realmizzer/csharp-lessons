using System;

namespace Static
{
    internal class NonStaticClass
    {
        public NonStaticClass() 
        {
            Console.WriteLine("Non Static Constructor");
        }

        static NonStaticClass()
        {
            Console.WriteLine("Static Constructor");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }

        public void NonStaticMethod()
        {
            Console.WriteLine("Non Static Method");
        }
    }
}
