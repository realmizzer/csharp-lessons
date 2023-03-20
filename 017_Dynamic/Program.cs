using System;

namespace _017_Dynamic
{
    struct Point
    {
        dynamic x, y;

        public Point(dynamic x, dynamic y)
        {
            this.x = x;
            this.y = y;
        }

        // При расширении бинарных операторов, один из аргументов
        // должен быть обязательно должен иметь существующий тип.
        public static dynamic operator +(Point pA, dynamic pB)
        {
            return new Point(pA.x + pB.x, pA.y + pB.y);
        }

        // В унарных операторах использовать тип dynamic - недопустимо.
        public static Point operator ++(Point p)
        {
            return new Point(p.x + 1, p.y + 1);
        }

        public override string ToString()
        {
            return this.x + " " + this.y;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Point p = new Point(2, 3);
            Point p2 = new Point(3, 2);

            Console.WriteLine(p + p2);
            Console.WriteLine(p++);
        }
    }
}
