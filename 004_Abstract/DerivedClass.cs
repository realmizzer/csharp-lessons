using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class DerivedClass : AbstractBaseClass
    {
        public override void AbstractMethod()
        {

            Console.WriteLine("Implementing abstract method...");
        }
    }
}
