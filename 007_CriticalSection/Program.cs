using System;
using System.Threading;

namespace _007_CriticalSection
{
    class MyClass
    {
        // Объект блокировки или
        // объект синхронизации доступа к разделяемому ресурсу.
        readonly object block = new object();

        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();

            // Критическая секция.
            lock (block)
            {
                // Разделяемый ресурс.
                for(int counter = 0; counter < 10; counter++)
                {
                    Console.WriteLine("Поток # {0}, шаг: {1}", hash, counter);
                    Thread.Sleep(200);
                }

                Console.WriteLine(new string('-', 20));
            }
            // Пока не выполнится секция выше, следующий поток не начнётся (синхронизация потоков).
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            // Создание трёх разных потоков.
            for(int i = 0; i < 3; i++)
            {
                new Thread(instance.Method).Start();
            }

            Thread.Sleep(500);

            Console.ReadKey();
        }
    }
}
