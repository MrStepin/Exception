using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Exception;
using Assert = Exception.Assert;
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

            int referenceValue = 10;

            MyAsserts.AssertMoreThan.Greater(maximum, referenceValue);
        }

        [Test]
        public void CheckEquals()
        {
            int[] testMassive = new int[] { 16, 17, 18, 19 };

            int maximum = Program.Maximum(testMassive);

            int referenceValue = 19;

            MyAsserts.AssertMoreThan.Equals(maximum, referenceValue);
        }

        [Test]
        public void CheckThrowsNull()
        {
            string url = null;
            Action action = () => { Program.Download(url); };
            MyAsserts.AssertMoreThan.Throws(action);
        }
        [Test]
        public void CheckThrowsNotNull()
        {
            string url = "a";
            Action action = () => { Program.Download(url); };
            MyAsserts.AssertMoreThan.Throws(action);
        }
        [Test]
        public void CheckThrowsErr()
        {
            string url = "a";
            Action action = () => { Program.DownloadErr(url); };
            MyAsserts.AssertMoreThan.Throws(action);
        }
    }
}
