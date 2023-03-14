using System;
using System.Threading;

// Передача данных в поток.
namespace _004_Threads
{
    class Box
    {
        public string food = "chips";
        public string cloth = "jeans";
        public string shoes = "shoes";
    }

    class Program
    {
        // Аргументы приходят обязательно в коробке.
        static void WriteSecond(object argument)
        {
            Box box = (Box)argument;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(box.food);
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(WriteSecond);
            Thread thread = new Thread(parameterizedThreadStart);
            thread.Start(new Box());

            Thread.Sleep(3000);

            Console.ReadKey();
        }
    }
}
