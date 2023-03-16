using System;


namespace _006_Exceptions
{
    class ExceptionA : Exception
    {
        public ExceptionA(string message)
            : base(message) { }
    }

    class ExceptionB : ExceptionA 
    {
        public ExceptionB(string message)
            : base (message) { }
    }

    internal class Program
    {
        static void Main()
        {
            try
            {
                //throw new Exception("Exception");
                throw new ExceptionA("ExceptionA");
                //throw new ExceptionB("ExceptionB");
            }
            // catch необходимо перечислять
            // "вверх тормашками".
            catch(ExceptionB e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ExceptionA e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
