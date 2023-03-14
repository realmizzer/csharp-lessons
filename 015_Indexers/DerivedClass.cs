namespace Indexers
{
    class DerivedClass : BaseClass
    {
        private readonly string[] derivedArray = null;

        public DerivedClass()
        {
            derivedArray = new string[3];
            derivedArray[0] = "Zero";
            derivedArray[1] = "One";
            derivedArray[2] = "Two";
        }

        public override string this[int index]
        {
            get
            {
                return base[index] + " - " + derivedArray[index];
            }
        }
    }
}
