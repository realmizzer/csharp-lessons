using System;
using System.Collections;
using System.Collections.Generic;

namespace _004_List
{
    internal class Program
    {
        static void Main()
        {
            // Non-generic collection.
            ArrayList arrayList = new ArrayList();

            // Boxing.
            arrayList.Add(1);
            arrayList.Add((object)2);

            // Unboxing.
            for(int i = 0; i < arrayList.Count; i++)
                Console.WriteLine((int)arrayList[i]);

            Console.WriteLine(new string('-', 3));

            // Generic collection.
            List<int> ints = new List<int>();

            ints.Add(1);
            ints.Add(2);

            Console.WriteLine("{0} - {1}", ints[0], ints.Contains(0));

            Console.ReadKey();
        }
    }
}
