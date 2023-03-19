using System;

namespace _003_ClassObject
{
    class Point : object
    {
        protected int x, y;

        public Point(int xValue, int yValue)
        {
            x = xValue;
            y = yValue;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Point point = (Point)obj;
            return (x == point.x) && (y == point.y);
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Point point1 = new Point(1, 2);
            Point point2 = new Point(1, 2);

            // Equals сравнивает хеши.
            Console.WriteLine(point1.Equals(point2));
            Console.WriteLine(Equals(point1, point2));

            // ReferenceEquals сравнивает ссылки в памяти.
            Console.WriteLine(ReferenceEquals(point1, point2));

            Console.ReadKey();
        }
    }
}
