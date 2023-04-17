using System;
using System.Collections;

namespace _001_ArrayList
{
    internal class Program
    {
        static void Main()
        {
            var list = new ArrayList() { 2, 3, 1 };

            list.Sort(new DescendingComparer());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    public class DescendingComparer : IComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            int result = -1 * comparer.Compare(x, y);

            return result;
        }
    }
}
