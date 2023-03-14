using System;
using System.Collections;

namespace Yield
{

    class CustomCollection
    {
        public static IEnumerable Power()
        {
            // По сути тот же null, но безопасный.
            // Возвращает false в компиляторе.
            yield break;
        }
    }
}
