using System;
using System.Drawing;

namespace Session_02
{
    internal class Question6
    {
        public static void Run()
        {
            Point p1 = new Point(1, 2);
            Point p2 = p1;

            p2.X = 99;

            Console.WriteLine("p1.X = " + p1.X); // also 99!
            Console.WriteLine("p2.X = " + p2.X); // 99

            // What happens:
            // Point is a reference type (a class), stored on the heap.
            // "p2 = p1" does NOT copy the object - it copies the REFERENCE (the address).
            // Both p1 and p2 now point to the same object in memory, so changing
            // a property through p2 is visible through p1 as well.
        }
    }
}