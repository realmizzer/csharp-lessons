using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _003_ICollectionT
{
    internal class UserCollection<T> : ICollection<T>
    {
        T[] elements = new T[0];

        public int Count => elements.Length;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            var newArray = new T[elements.Length + 1];
            elements.CopyTo(newArray, 0);
            newArray[newArray.Length - 1] = item;
            elements = newArray;
        }

        public void Clear()
        {
            elements = new T[0];
        }

        public bool Contains(T item)
        {
            foreach (var element in elements)
            {
                if (element.Equals(item))
                    return true;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            T[] arr = array;

            if (arr == null)
                throw new ArgumentException("Array is null.");

            for (int i = 0; i < array.Length; i++)
            {
                arr[arrayIndex++] = elements[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)elements).GetEnumerator();
        }

        public bool Remove(T item)
        {
            // хз как сделать

            if (elements.Contains(item))
            {
                return true;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }
    }
}
