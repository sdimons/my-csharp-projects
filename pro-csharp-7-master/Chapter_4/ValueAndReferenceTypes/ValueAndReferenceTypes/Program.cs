using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueAndReferenceTypes
{
    #region Simple structure
    struct Point
    {
        public int X;
        public int Y;

        public void Display()
        {
            Console.WriteLine
                ("X = {0}, Y = {1}", X, Y);
        }

        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }
    }
    #endregion

    #region Simple class
    class PointRef
    {
        public int X;
        public int Y;

        public void Display()
        {
            Console.WriteLine
                ("X = {0}, Y = {1}", X, Y);
        }

        public PointRef(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }
    }
    #endregion

    #region Struct containing class!
    class ShapeInfo
    {
        public string InfoString;
        public ShapeInfo(string info)
        { InfoString = info; }
    }

    struct Rectangle
    {
        public ShapeInfo RectInfo;

        public int RectTop, RectLeft, RectBottom, RectRight;

        public Rectangle(string info, int top, int left, 
            int bottom, int right)
        {
            RectInfo = new ShapeInfo(info);
            RectTop = top; RectBottom = bottom;
            RectLeft = left; RectRight = right;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
                              "Left = {3}, Right = {4}",
                RectInfo.InfoString, RectTop, RectBottom, 
                RectLeft, RectRight);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Values types / Reference types *****\n");
            ValueTypeAssignment();
            Console.WriteLine();

            ReferenceTypeAssignment();
            Console.WriteLine();

            ValueTypeContainingRefType();
            Console.ReadLine();
        }

        #region Structures and assignment operator
        // Assigning two intrinsic value types results in
        // two independent variables on the stack.
        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning value types\n");

            Point p1 = new Point(10, 10);
            Point p2 = p1;

            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }
        #endregion

        #region Classes and assignment operator
        static void ReferenceTypeAssignment()
        {
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            p1.Display();
            p2.Display();

            p1.X = 100;
            Console.WriteLine("\n=> Changed p1.X\n");
            p1.Display();
            p2.Display();
        }
        #endregion

        #region Value types containing ref types
        static void ValueTypeContainingRefType()
        {
            // Create the first Rectangle.
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

            // Now assign a new Rectangle to r1.
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;

            // Change some values of r2.
            Console.WriteLine("-> Changing values of r2");
            r2.RectInfo.InfoString = "This is new info!";
            r2.RectBottom = 4444;

            // Print values of both rectangles.
            r1.Display();
            r2.Display();
        }
        #endregion

        static void LocalValueTypes()
        {
            int i = 0; //структура System.Int32
            Point p = new Point(); // Структура Point
        } // Здесь i и p покидают стек!
    }
}
