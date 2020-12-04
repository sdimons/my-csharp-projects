using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunWithStructures
{
    #region Simple structure
    struct Point
    {
        public int X;
        public int Y;

        public void Display()
        {
            Console.WriteLine(
                "X = {0}, Y = {1}", 
                X, Y);
        }
        public Point(int XPos, int YPos)
        {
            X = XPos;
            Y = YPos;
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** A First Look at Structures *****\n");
            // Create an initial Point.
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            // Adjust the X and Y values.
            //myPoint.Increment();
            myPoint.Display();

            // Set all fields to default values
            // using the default constructor.
            Point p1 = new Point();

            // Prints X=0,Y=0
            p1.Display();

            // Call custom constructor.
            Point p2 = new Point(50, 60);

            // Prints X=50,Y=60
            p2.Display();

            Console.ReadLine();
        }
    }
}
