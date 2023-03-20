using System;

namespace _001_Anonymous
{
    internal class Program
    {
        static void Main()
        {
            // Блок инициализатора.
            var instance = new { Name = "Max", Age = 20 };

            // Только для чтения.
            //instance.Name = "Dima";

            Console.WriteLine($"Name: {instance.Name}, Age: {instance.Age}");

            Type type = instance.GetType();

            Console.WriteLine(type);

            Console.ReadKey();
        }
    }
}
