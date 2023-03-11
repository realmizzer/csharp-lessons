using System;

namespace Extension
{
    static class ExtensionClass
    {
        // The extension's argument can be only one and first
        public static void ExtensionMethod(this string string1, string string2)
        {
            Console.WriteLine(string1 + string2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, ";
            text.ExtensionMethod("world!");

            Console.ReadKey();
        }
    }
}
