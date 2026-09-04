using System;

namespace Session_02
{
    internal class Question7
    {
        public static void Run()
        {
            string firstName = "Menna";
            string lastName = "Ahmed";

            // Concatenation with +
            string fullName1 = firstName + " " + lastName;
            Console.WriteLine(fullName1);

            // Concatenation with string interpolation
            string fullName2 = $"{firstName} {lastName}";
            Console.WriteLine(fullName2);
        }
    }
}