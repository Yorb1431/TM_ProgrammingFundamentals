using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Only take input without additional text prompts
            string antwoord = Console.ReadLine();  // Input is read as string

            // Convert the input string to an integer
            int getal = Convert.ToInt32(antwoord);

            // Convert the integer to its corresponding character (ASCII)
            char karakter = (char)getal;

            // Output the lowercase and uppercase versions of the character in one line
            Console.WriteLine($"{char.ToLower(karakter)}");
            Console.WriteLine($"{char.ToUpper(karakter)}");
        }
    }
}
