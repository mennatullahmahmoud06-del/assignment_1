using System;

namespace Session_02
{
    internal class Question3
    {
        public static void Run()
        {
            float a = 0.1F;
            float b = 0.2F;
            float sum = a + b;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("a + b = " + sum);

            // What happens:
            // Floating-point numbers (float/double) are stored in binary, and values like
            // 0.1 and 0.2 cannot be represented exactly in binary. So "a + b" does NOT
            // print exactly 0.3 - it prints something like 0.3 with tiny rounding error
            // hidden in the deeper decimal places (visible if you print with more precision).
            Console.WriteLine("Is a + b == 0.3F ? " + (sum == 0.3F)); // Often false due to precision loss
            Console.WriteLine("More precise view: " + sum.ToString("F10"));
        }
    }
}