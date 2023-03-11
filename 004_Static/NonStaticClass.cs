using System;

namespace Static
{
    internal class NonStaticClass
    {
        static int field;

        public static int Property
        {
            get => field;
            set => field = value;
        }
    }
}
