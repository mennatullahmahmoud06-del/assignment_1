using System;

namespace Session_02
{
    internal class Question8
    {
        public static void Run()
        {
            int d;
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine("d = " + d);

            // Explanation:
            // 30 < 20 is FALSE.
            // !(false) = true
            // Convert.ToInt32(true) = 1
            // So d = 1.
            // Correct answer: 2. A value 1 will be assigned to d.
        }
    }
}