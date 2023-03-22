using System;

namespace ClassLibrary
{
    // Если добавить модификатор internal,
    // то в другом проекте нельзя будет достать
    // данный класс через ссылку.
    public class Dialog
    {
        public static void Main()
        {
            
        }

        /// <summary>
        /// Greetings.
        /// </summary>
        public void Greetings()
        {
            Console.WriteLine("Hello from DLL!");
        }
    }
}
