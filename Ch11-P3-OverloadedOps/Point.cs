using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P3_OverloadedOps
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public override string ToString() => $"[{this.X}, {this.Y}]";

        // Add 1 to the X/Y values for the incoming Point.
        public static Point operator ++(Point p1) => new Point(p1.X + 1, p1.Y + 1);
        // Subtract 1 from the X/Y values for the incoming Point.
        public static Point operator --(Point p1) => new Point(p1.X - 1, p1.Y - 1);

        // overload operator +
        public static Point operator +(Point p1, int change)
        {
            return new Point(p1.X + change, p1.Y + change);
        }

        //// overload operator +
        //public static Point operator +( int change , Point p1)
        //{
        //    return new Point(p1.X + change, p1.Y + change);
        //}
        // overload operator -
        public static Point operator -(Point p, int change)
        {
            return new Point(p.X - change, p.Y - change);
        }
        // overload operator +
        public static Point operator + ( Point p1 , Point p2 )
        {
           return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }
    }
}
