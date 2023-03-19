using System;

namespace _008_Operators
{
    internal class Point : IComparable
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator >(Point p1, Point p2) 
        {
            return p1.CompareTo(p2) > 0;
        }

        public static bool operator <(Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public int CompareTo(object obj)
        {
            if(obj is Point point)
            {
                if(this.x > point.x && this.y > point.y)
                {
                    return 1;
                }
                else if(this.x < point.x && this.y < point.y)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
