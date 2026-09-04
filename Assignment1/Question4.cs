using System;

namespace Session_02
{
    internal class Question4
    {
        public static void Run()
        {
            string text = "Communication and Information Engineering";

            // Substring(startIndex, length)
            string sub1 = text.Substring(0, 13); // "Communication"
            Console.WriteLine("Substring(0, 13): " + sub1);

            // Substring(startIndex) - takes everything from startIndex to the end
            string sub2 = text.Substring(18);
            Console.WriteLine("Substring(18): " + sub2);
        }
    }
}