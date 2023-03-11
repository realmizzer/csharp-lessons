using System;

namespace Extension
{
    // Methods in extensions can be overloaded but can't have optional parameters
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
        public static void ExtensionMethod(this string string1, string string2)
        {
            Console.WriteLine(string1 + string2);
        }
        public static void ExtensionMethod(this int value)
        {
            Console.WriteLine(value);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, ";

            text.ExtensionMethod();
            // literal
            "Hello ".ExtensionMethod("world!");

            2.ExtensionMethod();
        }
    }
}
