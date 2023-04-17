using System;
using System.Collections;

namespace Iterator.Pattern
{
    internal class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList elements = new ArrayList();
        private ConcreteIterator iterator;

        public int Count => elements.Count;

        public override object this[int index] 
        {
            get => elements[index];
            set => elements.Insert(index, value); 
        }

        public override Iterator CreateIterator()
        {
            iterator = new ConcreteIterator(this);
            return iterator;
        }
    }
}
