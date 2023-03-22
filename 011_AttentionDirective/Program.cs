using System;

namespace _011_AttentionDirective
{
    internal class Program
    {
        static void Main()
        {
#warning Здесь пока не трогать!
            Console.WriteLine("Don't touch me!");

            // Позволяет создать ошибку первого уровня и даёт
            // коду скомпилироваться.
#error Ошибка, определённая пользователем.
            Console.WriteLine("Directive Custom Error.");

            Console.ReadKey();
        }
    }
}
