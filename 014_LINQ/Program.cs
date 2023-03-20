using System;
using System.Linq;
namespace _014_LINQ
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Группировка (group by) создаёт дополнительные коллекции.
            var query = from x in numbers
                        group x by x % 3;

            foreach(var group in query)
            {
                Console.WriteLine($"Key {group.Key}");

                foreach(var number in group)
                {
                    Console.Write($"{number}, ");
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
