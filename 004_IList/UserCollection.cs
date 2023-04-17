using System;
using System.Collections;

namespace _004_IList
{
    internal class UserCollection : IList
    {
        private readonly object[] elements = new object[8];
        private int count;

        public UserCollection()
        {
            count = 0;
        }

        public object this[int index] { get => elements[index]; set => elements[index] = value; }

        public bool IsReadOnly => false;

        public bool IsFixedSize => true;

        public int Count => count;

        public object SyncRoot => new object();

        public bool IsSynchronized => true;

        public int Add(object value)
        {
            if (count < elements.Length)
            {
                elements[count] = value;
                count++;

                return (count - 1);
            }

            return -1;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(object value)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == value)
                    return true;
            }

            return false;
        }

        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(elements[i], j);
                j++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return elements[i];
            }

            //return elements.GetEnumerator();
        }

        public int IndexOf(object value)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == value)
                    return i;
            }

            return -1;
        }

        public void Insert(int index, object value)
        {
            if ((count + 1 <= elements.Length) && (index < Count) && (index >= 0))
            {
                count++;

                for (int i = Count - 1; i > index; i--)
                {
                    elements[i] = elements[i - 1];
                }

                elements[index] = value;
            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) & (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    elements[i] = elements[i + 1];
                }

                count--;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Ёмкость: {0}; количество элементов: {1}", elements.Length, count);
            Console.WriteLine("Элементы списка:");

            for (int i = 0; i < count; i++)
            {
                Console.Write(" {0}", elements[i]);
            }

            Console.WriteLine("\n" + new string('-', 5));
        }
    }
}
