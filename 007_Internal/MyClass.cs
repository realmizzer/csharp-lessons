using System;
using Library;

namespace _007_Internal
{
    class MyClass : MyPublicClass
    {
        public void Method()
        {
            base.PublicMethod();
            base.InternalProtectedMethod();
            base.ProtectedInternalClassMethod();
        }
    }
}
