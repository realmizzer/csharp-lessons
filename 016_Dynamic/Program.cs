using System;
namespace _016_Dynamic
{
    internal class Program
    {
        static dynamic Method(dynamic argument)
        {
            return "Hello, " + argument + "!";
        }
        static void Main()
        {
            string @string = Method("dynamic");
            Console.WriteLine(@string);

            Console.ReadKey();
        }
    }
}
