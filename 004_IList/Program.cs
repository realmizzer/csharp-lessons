using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_IList
{
    internal class Program
    {
        static void Main()
        {
            var collection = new UserCollection() { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            collection.PrintInfo();

            Console.WriteLine("Удаление...");
            collection.Remove("six");
            collection.Remove("five");
            collection.PrintInfo();

            Console.WriteLine("Добавление элемента в конец...");
            collection.Add("Ten");
            collection.PrintInfo();

            Console.WriteLine("Список содержит /six/? {0}", collection.Contains("Six"));

            Console.WriteLine("Список всех элементов коллекции:");
            foreach (string s in collection)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();


        }
    }
}
