using System;

namespace Session_02
{
    internal class Question5
    {
        public static void Run()
        {
            int x = 10;
            int y = x; // y gets a COPY of x's value

            y = 20; // modifying y

            Console.WriteLine("x = " + x); // still 10
            Console.WriteLine("y = " + y); // 20

            // What happens:
            // int is a value type, stored directly on the stack.
            // "y = x" copies the actual value into y - x and y are now two
            // completely independent variables. Changing y has no effect on x.
        }
    }
}