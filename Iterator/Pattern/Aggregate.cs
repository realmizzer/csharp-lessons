using System;

namespace Iterator.Pattern
{
    abstract internal class Aggregate
    {
        public abstract Iterator CreateIterator();
        public abstract object this[int index] { get; set; }
    }
}
