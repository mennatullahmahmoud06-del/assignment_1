using System;

namespace Session_02
{
    internal class Question4
    {
        public static void Run()
        {
            string text = "Communication and Information Engineering";

            string sub1 = text.Substring(0, 13);
            Console.WriteLine("Substring(0, 13): " + sub1);

            string sub2 = text.Substring(18);
            Console.WriteLine("Substring(18): " + sub2);
        }
    }
}