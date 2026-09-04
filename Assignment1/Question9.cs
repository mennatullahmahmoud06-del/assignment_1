using System;

namespace Session_02
{
    internal class Question9
    {
        public static void Run()
        {
            Console.WriteLine(13 / 2 + " " + 13 % 2);

            // Explanation:
            // 13 and 2 are both int, so 13 / 2 is INTEGER division = 6 (fraction discarded, not rounded).
            // 13 % 2 = remainder of 13 / 2 = 1.
            // Output: "6 1"
            // Correct answer: 4. 6 1
        }
    }
}