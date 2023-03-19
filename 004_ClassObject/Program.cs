using System;

namespace _004_ClassObject
{
    class MyBaseClass
    {
        public static string CompanyName = "Microsoft";
        public int age;
        public string name;
    }

    internal class MyDerivedClass : MyBaseClass
    {
        static void Main()
        {
            MyDerivedClass original = new MyDerivedClass();
            original.age = 42;
            original.name = "Singularity";

            Console.WriteLine($"{original.name}, {original.age} - {MyDerivedClass.CompanyName}");

            // Поверхностное клонирование.
            //MyDerivedClass clone = original;

            // Глубокое (частичное) клонирование.
            // Частичным оно называется потому, что при клонировании,
            // если есть поля с ссылочным типотом, то он их не клонирует,
            // а начинает ссылаться к ним уже с клонированного к оригинальному.
            MyDerivedClass clone = original.MemberwiseClone() as MyDerivedClass;
            Console.WriteLine($"{clone.name}, {clone.age} - {MyDerivedClass.CompanyName}");

            clone.age = 20;
            clone.name = "Max";
            MyBaseClass.CompanyName = "Google";

            Console.WriteLine($"{original.name}, {original.age} - {MyDerivedClass.CompanyName}");
            Console.WriteLine($"{clone.name}, {clone.age} - {MyDerivedClass.CompanyName}");

            Console.ReadKey();
        }
    }
}
