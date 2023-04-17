using System;
using System.Collections;
using System.Collections.Specialized;

// Создайте коллекцию типа OrderedDictionary
// и реализуйте в ней возможность сравнения значений.
// (не сделано)

namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            var orderedDictionary = new OrderedDictionary(new OrderedComparer())
            {
                { 1, "First" },
            };

            foreach (DictionaryEntry pair in orderedDictionary)
            {
                Console.WriteLine(pair.Key);
            }
        }
    }

    internal class OrderedComparer : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            x.Equals(y); return true;
        }

        public int GetHashCode(object obj)
        {
            return this.GetHashCode();
        }
    }

}
