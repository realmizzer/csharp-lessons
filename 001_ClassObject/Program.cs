using System;

namespace _001_ClassObject
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
            if(obj == null || this.GetType() != obj.GetType()) 
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
            Point a = new Point(1, 2);
            Point b = new Point(1, 2);
            Point c = new Point(0, 0);

            Console.WriteLine("a hash {0}", a.GetHashCode());
            Console.WriteLine("b hash {0}", b.GetHashCode());
            Console.WriteLine("c hash {0}", c.GetHashCode());

            Console.WriteLine("a == b : {0}", a.Equals(b));
            Console.WriteLine("a == c : {0}", a.Equals(c));

            Console.WriteLine("a == b : {0}", Equals(a, b));
            Console.WriteLine("a == c : {0}", Equals(a, c));;

            Console.ReadKey();
        }
    }
}
