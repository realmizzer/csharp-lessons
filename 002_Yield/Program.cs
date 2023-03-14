using System;
using System.Collections;

namespace Yield
{
    class Program
    {
        static void Main()
        {
            foreach(string element in CustomCollection.Power())
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(new string('-', 30));

            IEnumerator enumerator = CustomCollection.Power().GetEnumerator();

            while(enumerator.MoveNext())
            {
                string element = enumerator.Current as String;

                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}
