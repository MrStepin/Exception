using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception;


namespace Exception
{
    public class Program
    {
        public static int Maximum (int[] massive)
        {
            if (massive.Length == 0)
            {
                throw new ArgumentException();
            }
            int maximum = massive[0];
            for (int i = 0; i < massive.Length; i++)
            {
                if(maximum < massive[i])
                {
                    maximum = massive[i];
                }
            }
            return maximum;
        }

        public static string Download(string url)
        {
            if (url == null)
                throw new System.Exception();

            return "content";
        }

        public static string DownloadErr(string url)
        {
            return "content";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 0 to 4.");
            int numOfMassive = Convert.ToInt16(Console.ReadLine());

            int[][] testMassive = new int[5][];
            testMassive[0] = new int[] { };
            testMassive[1] = new int[] { 4, 5, 6, 7 };
            testMassive[2] = new int[] { 8, 9, 10, 11 };
            testMassive[3] = new int[] { 12, 13, 14, 15 };
            testMassive[4] = new int[] { 16, 17, 18, 19 };
            try
            {
                Console.WriteLine(Maximum(testMassive[numOfMassive]));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Massive is empty");
            }
            Console.ReadKey();
        }
    }
}
