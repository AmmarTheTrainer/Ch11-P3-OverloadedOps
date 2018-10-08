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
            Console.WriteLine("***** Fun with Overloaded Operators *****\n");

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

            #region Overloading Binary Operators

            //// Make two points.
            //Point ptOne = new Point(100, 100);
            //Point ptTwo = new Point(40, 40);
            //Console.WriteLine("ptOne = {0}", ptOne);
            //Console.WriteLine("ptTwo = {0}", ptTwo);
            //// Add the points to make a bigger point?
            //Console.WriteLine("ptOne + ptTwo: {0} ", ptOne + ptTwo);
            //// Subtract the points to make a smaller point?
            //Console.WriteLine("ptOne - ptTwo: {0} ", ptOne - ptTwo);

            ////Point p3 = Point.operator +(ptOne, ptTwo);

            //// Prints [110, 110].
            //Point biggerPoint = ptOne + 10;
            //Console.WriteLine("ptOne + 10 = {0}", biggerPoint);
            //// Prints [120, 120].
            ////Console.WriteLine("10 + biggerPoint = {0}", 10 + biggerPoint);
            //Console.WriteLine();

            #endregion



            Console.ReadLine();
        }
    }
}
