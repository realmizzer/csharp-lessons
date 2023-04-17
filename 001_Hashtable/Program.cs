using System;
using System.Collections;

namespace HashtableDemo
{
    class Program
    {
        static void Main()
        {
            var emailLookup = new Hashtable();

            emailLookup.Add("sbishop@contoso.com", "Bishop, Scott");
            // emailLookup.Add("sbishop@contoso.com", "Bishop, Scott2");

            emailLookup["s.bishop@contoso.com"] = "Bishop, Scott";

            // Если такой индекс существует, то происходит только замена значения.
            emailLookup["sbishop@contoso.com"] = "-------------";


            Console.WriteLine(emailLookup["sbishop@contoso.com"]);
            Console.WriteLine(emailLookup["s.bishop@contoso.com"]);
        }
    }
}
