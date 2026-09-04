using System;

namespace Session_02
{
    internal class Question1
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
    }
}