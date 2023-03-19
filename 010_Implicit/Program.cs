using System;

namespace _010_Explicit
{
    struct Digit
    {
        public byte value;

        Digit(byte value)
        {
            this.value = value;
        }

        // Оператор неявного преобразования.
        public static implicit operator Digit(byte variable)
        {
            Digit digit = new Digit(variable);
            return digit;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }
    }

    internal class Program
    {
        static void Main()
        {
            byte variable = 1;

            Digit digit = variable;
            Console.WriteLine(digit);

            Console.ReadKey();
        }
    }
}
