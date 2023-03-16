using System;

namespace _002_Exceptions
{
    class UserException : Exception
    {
        public void Method()
        {
            Console.WriteLine("Моё исключение.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            try
            {
                throw new UserException();
            }
            catch (UserException e)
            {
                Console.WriteLine("Обработчка исключения");
                e.Method();
            }

            Console.ReadKey();
        }
    }
}
