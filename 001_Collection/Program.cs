using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCollection;

namespace _001_Collection
{
    internal class Program
    {
        static void Main()
        {
            var collection = new UserCollection<Element>();

            collection[0] = new Element(1, 2);
            collection[1] = new Element(3, 4);
            collection[2] = new Element(5, 6);
            collection[3] = new Element(7, 8);

            foreach (Element element in collection)
            {
                Console.WriteLine("{0}, {1}", element.PropertyA, element.PropertyB);
            }

            Console.WriteLine(new string('-', 5));

            foreach (Element element in collection)
            {
                Console.WriteLine("{0}, {1}", element.PropertyA, element.PropertyB);
            }

            Console.ReadKey();
        }
    }
}
