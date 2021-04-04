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
        public void CheckGreater()
        {
            int [] testMassive = new int[] { 16, 17, 18, 19 };

            int maximum = Program.Maximum(testMassive);

            int ReferenceValue = 10;

            MyAsserts.AssertMoreThan.Greater(maximum, ReferenceValue);
        }

        [Test]
        public void CheckEquals()
        {
            int[] testMassive = new int[] { 16, 17, 18, 19 };

            int maximum = Program.Maximum(testMassive);

            int ReferenceValue = 19;

            MyAsserts.AssertMoreThan.Equals(maximum, ReferenceValue);
        }
    }
}
