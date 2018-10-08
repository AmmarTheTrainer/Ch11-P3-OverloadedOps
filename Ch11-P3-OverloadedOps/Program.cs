using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P3_OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Overlaoding example

            // The + operator with ints.
            int a = 100;
            int b = 240;
            int c = a + b; // c is now 340

            // + operator with strings.
            string s1 = "Hello";
            string s2 = " world!";
            string s3 = s1 + s2; // s3 is now "Hello World!"

            #endregion



            Console.ReadLine();
        }
    }
}
