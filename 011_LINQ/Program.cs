using System;
using System.Collections;
using System.Linq;

namespace _011_LINQ
{
    internal class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);

            // Для непараметизированных(non-generic) IEnumarable нужно явно указывать
            // тип, с которым необходимо работать.
            var query = from int x in arrayList
                        select x * 2;

            foreach(var item in query)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
