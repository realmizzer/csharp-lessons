using System;
using System.Collections;

namespace CustomCollection
{
    class Program
    {
        static void Main()
        {
            CustomCollection customCollection = new CustomCollection();

            foreach(Element element in customCollection)
            {
                Console.WriteLine($"Name: {element.Name}, Field1: {element.Field1}, Field2: {element.Field2}");
            }

            Console.WriteLine(new string('-', 30));

            // --------------------------------------------------------------------------------------------------

            CustomCollection myCollection = new CustomCollection();

            // Позволяет получить перечислитель.
            IEnumerable enumerable = myCollection as IEnumerable;

            // Получение перечислителя.
            IEnumerator enumerator = enumerable.GetEnumerator();

            // Перебор неуниверсальной коллекции.
            while(enumerator.MoveNext())
            {
                // Переменная итерации.
                Element element = enumerator.Current as Element;

                Console.WriteLine($"Name: {element.Name}, Field1: {element.Field1}, Field2: {element.Field2}");
            }

            //enumerator.Reset();

            Console.ReadKey();
        }
    }
}
