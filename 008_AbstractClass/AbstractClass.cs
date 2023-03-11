using System;

namespace Abstract
{
    internal abstract class AbstractClass
    {
        public static AbstractClass CreateObject()
        {
            return new ConcreteClass();
        }

        public abstract void Method();
    }
}
