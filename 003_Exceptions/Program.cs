using System;

namespace _003_Exceptions
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
            catch (UserException userException)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Обработчка исключения");
                userException.Method();

                try
                {
                    throw userException;
                }
                catch (UserException exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Обработка исключения 2.");
                    exception.Method();
                }
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine("Конец программы.");

            Console.ReadKey();
        }
    }
}
