using System;

namespace _002_Anonymous
{
    internal class Program
    {
        static void Main()
        {
            var instance = new { Name = "Max", Age = 20, Id = new { Number = 123 } };

            Console.WriteLine($"{instance.Name}, {instance.Age} - {instance.Id.Number}");

            Console.ReadKey();
        }
    }
}
