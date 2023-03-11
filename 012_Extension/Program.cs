using System;

namespace Extension
{
    // Must be only static that has only static methods
    // We can't derive from string class, but we can dynamic derive by extensions
    static class ExtensionClass
    {
        // Keywoard 'this' means that method is extension
        // Dynamic deriving
        public static void ExtensionMethod(this string value)
        {
            Console.WriteLine(value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Test string";

            ExtensionClass.ExtensionMethod(text);

            text.ExtensionMethod();

            Console.ReadKey();
        }
    }
}
