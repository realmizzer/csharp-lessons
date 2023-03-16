using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace _001_Exceptions
{
    class MyClass
    { 
        public void MyThrowException()
        {
            Exception exception = new Exception("Моё исключение");

            exception.HelpLink = "https://google.com";
            exception.Data.Add("Причина исключения:", "Тест");
            exception.Data.Add("Время возникновения исключеиня: ", DateTime.Now);

            throw exception;
        }
    }

    internal class Program
    {
        static void Main()
        {
            try
            {
                MyClass instance = new MyClass();
                instance.MyThrowException();
            }
            catch (Exception e)
            {
                Console.WriteLine("Имя:         {0}", e.TargetSite);
                Console.WriteLine("Класс:       {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Тип:         {0}", e.TargetSite.MemberType);
                Console.WriteLine("Сообщение:   {0}", e.Message);
                Console.WriteLine("Источник:    {0}", e.Source);
                Console.WriteLine("Помощь:      {0}", e.HelpLink);
                Console.WriteLine("Stack:       {0}", e.StackTrace);

                foreach(DictionaryEntry de in e.Data)
                {
                    Console.WriteLine("{0} : {1}", de.Key, de.Value);
                }
            }

            Console.ReadKey();
        }
    }
}
