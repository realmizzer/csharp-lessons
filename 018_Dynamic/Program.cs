using System;
using System.Collections;

namespace _018_Dynamic
{
    class UserCollection
    {
        public static IEnumerable Generator()
        {
            yield return new { Key = 0, Value = "Zero" };
            yield return new { Key = 1, Value = "One" };
            yield return new { Key = 2, Value = "Two" };
        }
    }

    internal class Program
    {
        static void Main()
        {
            // at-hoc полиморфизм.
            // (up/down)cast без инкапсуляции (сокрытии полей и реализации)
            foreach(dynamic item in UserCollection.Generator())
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }

            Console.ReadKey();

        }
    }
}
