using System;
using System.Collections;

namespace InterIEnumerable
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Реализация foreach.");

            CustomCollection customCollection = new CustomCollection();

            foreach(Element element in customCollection)
            {
                Console.WriteLine($"Name: {element.Name}, Field1: {element.Field1}, Field2: {element.Field2}");
            }

            // Если закомментировать, то при следующей итерации - ничего не выведится
            // т.к. все переменные итерации были пройдены.
            //customCollection.Reset();

            Console.WriteLine("");

            foreach (Element element in customCollection)
            {
                Console.WriteLine($"Name: {element.Name}, Field1: {element.Field1}, Field2: {element.Field2}");
            }

            Console.WriteLine(new string('-', 30));

            // --------------------------------------------------------------------------------------------------

            Console.WriteLine("Реализация IEnumarable и IEnumerator");

            CustomCollection myCollection = new CustomCollection();

            // Необходимо обязательно приводить к нижеперечисленным интерфейсам, т.к.
            // возможен такой вариант, где коллекция может унаследовать какой-либо класс,
            // который будет реализовать схожий метод с этими интрефейсами и, возможно,
            // не самый благоприятным способом.

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
