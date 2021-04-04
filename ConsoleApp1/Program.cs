using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAsserts
{
    public static class Program
    {
        public static void Greater(int condition, int[] testMassive)
        {
                if (condition <= 10)
                {
                    throw new ArgumentException();
                }
        }

        static void Main(string[] args)
        {

        }


    }
}
