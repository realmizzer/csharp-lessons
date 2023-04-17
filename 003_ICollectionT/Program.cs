using System;

namespace _003_ICollectionT
{
    internal class Program
    {
        static void Main()
        {
            var collection = new UserCollection<int> { 1, 2, 3 };

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(collection.Contains(2));

            Console.ReadKey();
        }
    }
}
