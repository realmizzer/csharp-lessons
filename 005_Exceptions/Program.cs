using System;

namespace _005_Exceptions
{
    internal class Program
    {
        public static void Method()
        {
            int[] arr = new int[10];
            Console.WriteLine(arr);
            Method();
        }

        static void Main()
        {
            try
            {
                Method();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //throw new Exception();

                //while(true)
                //    Console.WriteLine("true");
            }
            finally
            {
                // StackOverflowException - очень серьёзная ошибка,
                // поэтому блок кода finally НЕ сработает.

                // finally также не отработает, если в catch есть исключение,
                // которое никак не обрабатывается или catch не может закончить выполнение.
                while (true)
                    Console.WriteLine("Finally");
            }
        }
    }
}
