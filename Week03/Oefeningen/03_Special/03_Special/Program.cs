using System;
namespace _03_Special
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read a character from user input
            Console.Write("Enter a character: ");
            char ch = Console.ReadKey().KeyChar; // Read a single character
            Console.WriteLine(); // Move to the next line

            // Check if the character is a vowel
            if ("aeiouAEIOU".Contains(ch))
            {
                Console.WriteLine("vowel");
            }
            // Check if the character is a digit
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("digit");
            }
            // If none of the above, it's a special character
            else
            {
                Console.WriteLine("special character");
            }
        }
    }
}