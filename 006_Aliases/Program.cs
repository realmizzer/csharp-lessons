extern alias CL1;
extern alias CL2;

// Если пространства имён и классы в разных сборках совпадают,
// то необходимо использовать псевдонимы (aliases).
// Для этого нужно зайти в свойства ссылки проекта и ввести нужно название.

namespace _006_Aliases
{
    class Program
    {
        static void Main()
        {
            CL1.ClassLibrary.Class class1 = new CL1.ClassLibrary.Class();
            CL2.ClassLibrary.Class class2 = new CL2.ClassLibrary.Class();

            class1.Method();
            class2.Method();

            System.Console.ReadKey();
        }
    }
}
