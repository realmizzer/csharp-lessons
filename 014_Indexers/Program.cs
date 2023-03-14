using System;

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            Dictionary dictionary = new();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["бублик"]);
            Console.WriteLine(dictionary["ручка"]);

            Console.WriteLine(new string('-', 20));

            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadKey();
        }
    }
}
