using System;

namespace _004_Exceptions
{
    public class ClassWithException
    {
        public void ThrowInner()
        {
            throw new Exception("Throwed вложенное исключение.");
        }

        public void CatchInner()
        {
            try
            {
                this.ThrowInner();
            }
            catch(Exception e)
            {
                throw new Exception("Throwed внешнее исключение.", e);
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            ClassWithException myException = new ClassWithException();

            try
            {
                myException.CatchInner();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception caught: {0}", exception.Message);
                Console.WriteLine("Inner exception:  {0}", exception.InnerException.Message);
            }
        }
    }
}
