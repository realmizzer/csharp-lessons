using System;


// Example good struct design
namespace Structure
{
    struct ZipCode
    {
        int fiveDigitCode;
        int plusFourExtension;

        public ZipCode(int fiveDigitCode, int plusFourExtension)
        {
            this.fiveDigitCode = fiveDigitCode;
            this.plusFourExtension = plusFourExtension;
        }

        public ZipCode(int fiveDigitCode)
            : this(fiveDigitCode, 0)
        {
        }

        public int FiveDigitCode
        {
            get { return fiveDigitCode; }
        }

        public int PlusFourExtension
        {
            get { return plusFourExtension; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ZipCode zipCode = new ZipCode(64143, 1412);

            Console.WriteLine(zipCode.FiveDigitCode);
            Console.WriteLine(zipCode.PlusFourExtension);

            Console.ReadKey();
        }
    }
}
