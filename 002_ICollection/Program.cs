using System;

namespace _002_ICollection
{
    internal class Program
    {
        static void Main()
        {
            var collection = new UserCollection();

            foreach (var element in collection)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();

            Console.WriteLine(new string('-', 5));

            var array = new object[collection.Count];

            collection.CopyTo(array, 0);

            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }

            Console.ReadKey();
        }
    }
}
