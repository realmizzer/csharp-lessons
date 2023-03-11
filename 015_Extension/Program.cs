using System;

namespace Extension
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value, int counter)
        {
            counter--;
            Console.WriteLine("Before: {0}", value + counter);

            if (counter != 0)
                value.ExtensionMethod(counter);

            Console.WriteLine("After: {0}", value + counter);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, ";

            text.ExtensionMethod(3);

            Console.ReadKey();
        }
    }
}
