using System;
using System.Collections;
using System.Text;

namespace Homework.Dictionary
{
    internal class Dictionary : ICollection
    {
        private Word[] _words = { new Word(), new Word(), new Word(), new Word(), new Word() };
        private int _count = 0;


        public int Count => _count;

        public object SyncRoot => new object();

        public bool IsSynchronized => true;

        public string this[int index]
        {
            get => $"{_words[index].rus} - {_words[index].eng} - {_words[index].ua}";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < _words.Length; i++)
                {
                    if (_words[i].rus == index || _words[i].eng == index || _words[i].eng == index)
                        return $"{_words[i].rus} - {_words[i].eng} - {_words[i].ua}";
                }

                return $"Для слова {index} нет перевода.";
            }
        }


        public void Add(string ru, string en, string ua)
        {
            _words[_count].rus = ru;
            _words[_count].eng = en;
            _words[_count].ua = ua;

            _count++;
        }

        public void CopyTo(Array array, int index)
        {
            for (int i = 0; i < _words.Length; i++)
            {
                array.SetValue((object)_words[i], i + index);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
