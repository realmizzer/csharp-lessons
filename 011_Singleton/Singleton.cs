using System;

namespace Singleton
{
    internal class Singleton
    {
        private static Singleton instance = null;

        // For derived singleton classes
        protected Singleton()
        {

        }

        public static Singleton Instance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
