using System;

namespace Static
{
    internal class NonStaticClass
    {
        static readonly long readonlyField = 2;

        public static long ReadonlyField
        {
            get => NonStaticClass.readonlyField;
        }

        static NonStaticClass()
        {
            Console.WriteLine("ReadonlyField before constructor: {0}", NonStaticClass.ReadonlyField);
            readonlyField = 1;
        }
    }
}
