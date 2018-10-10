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

            #region += and –= Operators

            //Point ptOne = new Point(100, 100);
            //Point ptTwo = new Point(40, 40);
            //// Freebie +=
            //Point ptThree = new Point(90, 5);
            //Console.WriteLine("ptThree = {0}", ptThree);
            //Console.WriteLine("ptThree += ptTwo: {0}", ptThree += ptTwo);
            //// Freebie -=
            //Point ptFour = new Point(0, 500);
            //Console.WriteLine("ptFour = {0}", ptFour);
            //Console.WriteLine("ptFour -= ptThree: {0}", ptFour -= ptThree);

            #endregion

            #region Overloading Unary Operators

            //// Applying the ++ and -- unary operators to a Point.
            //Point ptFive = new Point(1, 1);
            //Console.WriteLine("++ptFive = {0}", ++ptFive); // [2, 2]
            //Console.WriteLine("--ptFive = {0}", --ptFive); // [1, 1]

            //// Apply same operators as postincrement/decrement.
            //Point ptSix = new Point(20, 20);
            //Console.WriteLine("ptSix++ = {0}", ptSix++); // [20, 20]
            //Console.WriteLine("ptSix-- = {0}", ptSix--); // [21, 21]
            #endregion

            #region Overloading Equality Operator

            //// Make two points.
            //Point ptOne = new Point(100, 100);
            //Point ptTwo = new Point(100, 100);



            //Console.WriteLine("ptOne == ptTwo : {0}", ptOne == ptTwo);
            //Console.WriteLine("ptOne != ptTwo : {0}", ptOne != ptTwo);

            #endregion

            #region Overloading Comparison Operators

            // Make two points.
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(100, 100);

            Console.WriteLine("ptOne < ptTwo : {0}", ptOne < ptTwo);
            Console.WriteLine("ptOne > ptTwo : {0}", ptOne > ptTwo);

            #endregion

            Console.ReadLine();
        }
    }
}
