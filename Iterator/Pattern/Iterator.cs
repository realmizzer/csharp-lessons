using System;

namespace Iterator.Pattern
{
    abstract internal class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
