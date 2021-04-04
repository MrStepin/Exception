using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    public static class AssertMoreThan
    {
        public static void Greater(object condition, int[] testMassive)
        {
            if (Program.Maximum(testMassive) <= 10)
            {
                throw new ArgumentException();
            }
        }
    }
}
