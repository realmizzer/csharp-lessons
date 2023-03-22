using System;

namespace Library
{
    public class MyPublicClass
    {
        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod");
        }

        // Доступен только в этой сборке и ни в какой другой.
        internal void InternalMethod()
        {
            Console.WriteLine("InternalMethod");
        }

        // Доступен в этой сборке или в классе другой сборки, который унаследован от класса.
        internal protected void InternalProtectedMethod()
        {
            Console.WriteLine("InternalProtectedMethod");
        }

        internal protected void ProtectedInternalClassMethod()
        {
            MyInternalClass myInternalClass = new MyInternalClass();

            myInternalClass.Method();
        }
    }
}
