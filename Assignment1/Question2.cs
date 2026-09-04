using System;

namespace Session_02
{
    internal class Question2
    {
        public static void Run()
        {
            string text = "123abc";

            // int.Parse will throw an exception because the string
            // is not a purely numeric value.
            try
            {
                int result = int.Parse(text);
                Console.WriteLine("Converted value: " + result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: The string \"" + text + "\" could not be converted to an integer.");
                Console.WriteLine("Exception message: " + ex.Message);
            }

            // What happens:
            // int.Parse (and Convert.ToInt32) expect the ENTIRE string to be a valid number.
            // Since "123abc" has non-numeric characters, a FormatException is thrown at runtime.
            // A safer alternative is int.TryParse, which returns false instead of throwing.
            bool success = int.TryParse(text, out int safeResult);
            Console.WriteLine("TryParse success? " + success + " | Result: " + safeResult);
        }
    }
}