using System;
using System.Collections;

namespace _002_ICollection
{
    internal class UserCollection : ICollection
    {
        readonly object syncRoot = new object();
        readonly object[] elements = { 1, 2, 3, 4 };

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                ((object[])array)[index++] = elements[i];
            }
        }

        public int Count => elements.Length;

        public IEnumerator GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        public object SyncRoot => syncRoot;

        public bool IsSynchronized => true;
    }
}
