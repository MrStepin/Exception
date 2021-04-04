using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Exception;
using Exception = System.Exception;

namespace Test
{
    public class Class1
    {
        [Test]
        public void CheckMassive()
        {
            int [] testMassive = new int[] { 16, 17, 18, 19 };

            int maximum = Program.Maximum(testMassive);

            MyAsserts.AssertMoreThan.Greater(maximum);

        }
    }
}
