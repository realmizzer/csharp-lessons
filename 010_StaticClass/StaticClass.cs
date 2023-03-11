using System;

namespace StaticClass
{
    // Can't create instance
    // Can't implements interfaces
    // Can't has non static methods or fields
    // Can't has instance constructors
    // Can't implemented and be implemented
    internal static class StaticClass // : object // extends only class Object
    {
        static StaticClass()
        {
            Console.WriteLine("Static Constructor");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("StaticClass.StaticMethod");
        }
    }
}
