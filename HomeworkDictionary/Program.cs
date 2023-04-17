using System;

namespace Homework.Dictionary
{
    internal class Program
    {
        static void Main()
        {
            var dictionary = new Dictionary
            {
                { "Спасибо", "Thank you", "Дякую" },
                { "Думать", "To think", "Бачить" },
            };

            Console.WriteLine(dictionary["Спасибо"]);
            Console.WriteLine(dictionary["Думать"]);
            Console.WriteLine(dictionary["Шо"]);

            Console.WriteLine(new string('-', 15));

            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadKey();
        }
    }
}
