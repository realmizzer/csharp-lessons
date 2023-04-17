using System.Collections;

namespace UserCollection
{
    internal class UserCollection<T>
    {
        readonly T[] elements = new T[4];

        public T this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        int position = -1;

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            // yield, по сути, сохраняет в себе значение
            // и при следующем обращении к методу, он его будет дальше итерировать
            // yield - это MoveNext(), Current и Reset().

            //while (true)
            //{
            //    if (position < elements.Length - 1)
            //    {
            //        position++;
            //        yield return elements[position];
            //    }
            //    else
            //    {
            //        Reset();
            //        yield break;
            //    }
            //}

            foreach (var element in elements)
            {
                yield return element;
            }
        }
    }
}
