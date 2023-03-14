using System;
using System.Collections;

namespace InterIEnumerable
{
    class MyClass
    {
        public bool MoveNext()
        {
            return true;
        }
    }

    class CustomCollection : IEnumerable //, : MyClass
    {
        public Element[] elementsArray = null;

        public CustomCollection()
        {
            elementsArray = new Element[4];
            elementsArray[0] = new Element("A", 1, 10);
            elementsArray[1] = new Element("B", 2, 10);
            elementsArray[2] = new Element("C", 3, 10);
            elementsArray[3] = new Element("D", 4, 10);
        }

        // Указатель текущий позиции в массиве.
        int position = -1;

        public object Current => elementsArray[position];

        public IEnumerator GetEnumerator()
        {
            // Замена метода из IEnumerator MoveNext() ...
            while (true)
            {
                if (position < elementsArray.Length - 1)
                {
                    position++;

                    // ... оператором автоматической генерации кода итератора (перечислителя) - yield.
                    yield return elementsArray[position];
                }
                else
                {
                    Reset();
                    yield break; // Выход из цикла.
                }
            }
        }

        public void Reset()
        {
            Console.WriteLine("Collection {0} reseted.", this.GetHashCode()); ;
            position = -1;
        }
    }
}
