using System;

// Импорт как проект, через ссылку.
using ClassLibrary;

// Импорт как отдельный файл.
// В него не включаются комментарии методов, полей и т.д.
// Работает как метадата, т.е. не показывает реализацию при F12.
using AnotherClassLibrary;

namespace _005_DLL
{
    internal class Program
    {
        static void Main()
        {
            Dialog dialog = new Dialog();
            Class1 class1 = new Class1();

            dialog.Greetings();
            class1.Method();

            Console.ReadKey();
        }
    }
}
