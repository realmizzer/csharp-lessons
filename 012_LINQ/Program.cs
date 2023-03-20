using System;
using System.Collections.Generic;
using System.Linq;

namespace _012_LINQ
{
    public class Result
    {
        public Result(int input, int output) 
        {
            Input = input;
            Output = output;
        }

        public int Input { get; set; }
        public int Output { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var query = from x in numbers
                        select new Result(x, x * 2);

            numbers[0] = 777;

            // Первый элемент будет равен 777, даже после выполнения query
            // Происхдит это потому, что инициализация самого запроса
            // происходит только в момент её обращения, то есть снизу в foreach.
            foreach(var item in query)
                Console.WriteLine($"Input {item.Input}, Output: {item.Output}");

            Console.ReadKey();
        }
    }
}
