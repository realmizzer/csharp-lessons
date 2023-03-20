using System;
using System.Linq;

namespace _015_LINQ
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // into как let, позволяет локально идентифицировать по отношению к запросу.
            // (только для group, как я понял)
            var query = from x in numbers
                        group x by x % 2 into partition
                        where partition.Key == 0
                        select new { Key = partition.Key, Count = partition.Count(), Group = partition };

            foreach(var item in query)
            {
                Console.WriteLine($"Key: {item.Key}");
                Console.WriteLine($"Count: {item.Count}");

                foreach(var number in item.Group)
                {
                    Console.Write($"{number}, ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
