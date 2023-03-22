using System;
namespace _010_LineDirective
{
    internal class Program
    {
        static void Main()
        {
            // Отображает линию при ошибке.
#line 9
            Console.WriteLine("Line 9");

            // Скрывает линию из дебага (отладчика).
#line hidden
            Console.WriteLine("Debug Hidden!");

            // Брейкпоинт.
#line default
            Console.WriteLine("Debug Default");

            Console.ReadKey();
        }
    }
}
