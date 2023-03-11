using System;

namespace Extension
{
    static class ExtensionClass
    {
        // Extension can't be ref or out but arguments can
        public static void ExtensionMethod(this int value1, ref int value2, out int sum)
        {
            sum = value1 + value2;
            Console.WriteLine("{0} + {1} = {2}", value1, value2, sum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int refValue = 7;
            int sum = 0;

            5.ExtensionMethod(ref refValue, out sum);

            Console.ReadKey();
        }
    }
}
