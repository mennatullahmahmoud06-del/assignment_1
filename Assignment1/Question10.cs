using System;

namespace Session_02
{
    internal class Question10
    {
        public static void Run()
        {
            int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            // Explanation:
            // num <= 0 -> 1 <= 0 -> false, so !(false) = true -> the IF branch runs.
            //
            // Evaluating left to right within the WriteLine argument:
            // ++num  : num becomes 2, expression value = 2
            // z++    : expression value = 5 (current z), THEN z becomes 6
            // ++z    : z becomes 7, expression value = 7
            //
            // First part: ++num + z++  = 2 + 5 = 7
            // Second part: ++z = 7
            // Output: "7 7"
            // Correct answer: 4. 7 7
        }
    }
}