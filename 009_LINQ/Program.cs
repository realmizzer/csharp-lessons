using System;
using System.Collections.Generic;
using System.Linq;

namespace _009_LINQ
{
    public static class MySet
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            Console.WriteLine("Вызвана собственная реализация Where");
            return Enumerable.Where(source, predicate);
        }
    }
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var query = from x in numbers
                        where x % 2 == 0
                        select x * 2;

            foreach(var item in query)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
