using System;

namespace Arrays
{
    // ковариантность и контрвариантность (инвариантные)

    // апкаст каждого элемента массива
    // даункаст каждого элемента массива
    public interface IAnimal
    {
        void Voice();
    }
    public class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Voice");
        }
        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }
    class Program
    {
        static void Main()
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

            for(int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            Console.WriteLine(new string('-', 10));

            IAnimal[] animal = dogs; // Ковариантность

            for(int i = 0; i < dogs.Length; i++)
            {
                animal[i].Voice();
                //animal[i].Jump();
            }

            Console.WriteLine(new string('-', 10));

            // контрвариантности нет в c#, т.к. здесь мы приводим явно

            // Dog[] aboba = animal; // такое не сработает

            dogs = (Dog[])animal; // это не контрвариантность

            for(int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            Console.ReadKey();
        }
    }
}
