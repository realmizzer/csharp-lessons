using System;
using System.Collections;

namespace Yield
{

    class CustomCollection
    {
        public static IEnumerable Power()
        {
            // Оператор автоматической генерации кода итератора
            yield return "Hello world!";
        }
    }
}
