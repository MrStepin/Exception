using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssert
{
    public static class Class1
    {
        public static void Greater(int condition, int[] testMassive)
        {
            if (condition <= 10)
            {
                throw new ArgumentException();
            }
        }
    }
}
