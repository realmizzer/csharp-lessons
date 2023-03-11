using System;

namespace Abstraction
{
    abstract class AbstractBaseClass
    {
        public void SimpleMethod()
        {
            Console.WriteLine("AbstractBaseClass.SimpleMethod");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("AbstractBaseClass.VirtualMethod");
        }

        public abstract void AbstractMethod();
    }
}
