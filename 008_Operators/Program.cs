using System;

namespace _008_Operators
{
    internal class Program
    {
        static void Main()
        {
            Point point = new Point(1, 2);
            Point point2 = new Point(2, 3);

            Console.WriteLine(point < point2);

            Console.ReadKey();
        }
    }
}
