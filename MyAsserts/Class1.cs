using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAsserts
{
    public static class AssertMoreThan
    {
        public static void Greater(int maximumOfMassive, int value)
        {
            if (maximumOfMassive <= value)
            {
                throw new ArgumentException();
            }
        }
    }
}
