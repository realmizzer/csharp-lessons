using System;

namespace _005_IClonable
{
    internal class Program
    {
        static void Main()
        {
            Point original = new Point(100, 100);
            Point clone = original.Clone() as Point;

            Console.WriteLine("Первая проверка");

            Console.WriteLine(original);
            Console.WriteLine(clone);

            clone.x = 0;

            Console.WriteLine("Вторая проверка");
            Console.WriteLine(original);
            Console.WriteLine(clone);

            Console.ReadKey();
        }
    }
}
