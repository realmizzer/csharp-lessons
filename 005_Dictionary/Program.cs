using System;
using System.Collections.Generic;

namespace _005_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            keyValuePairs.Add(0, "Ноль");
            keyValuePairs.Add(1, "Один");
            keyValuePairs.Add(2, "Два");
            keyValuePairs.Add(3, "Три");

            Console.WriteLine(keyValuePairs.ContainsValue("Ноль"));

            for(int i = 0; i < keyValuePairs.Count + 1; i++)
                Console.WriteLine("{0} - {1}", keyValuePairs.TryGetValue(i, out string text), text);


            Console.ReadKey();
        }
    }
}
