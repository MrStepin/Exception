using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyAsserts
{
    public static class AssertMoreThan
    {
        public static void Greater(int compareNumber, int value)
        {
            if (compareNumber <= value)
            {
                throw new ArgumentException();
            }
        }

        public static void Equals(int compareNumber, int value)
        {
            if (compareNumber != value)
            {
                throw new ArgumentException();
            }
        }

        public static void Throws(Action action)
        {
            try
            {
                action();
            }
            catch
            {
                return;
            }

            throw new Exception();
        }
    }
}
