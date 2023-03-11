using System;

namespace Static
{
    internal class NonStaticClass
    {
        // Константы не могут быть статическими,
        // так как уже являются таковыми.
        // Поле const относится к типу, а не к экземпляру типа.
        public const float e = 2.7182818f;
    }
}
