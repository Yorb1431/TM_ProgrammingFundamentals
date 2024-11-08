using System;
namespace Week05_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input string
            string input = Console.ReadLine();

            // Initialize counters
            int vowels = 0;
            int consonants = 0;
            int digits = 0;
            int others = 0;

            // Loop through each character in the input string
            foreach (char ch in input)
            {
                // Ignore spaces
                if (ch == ' ') continue;

                // Check if character is a vowel
                if ("aeiouAEIOU".IndexOf(ch) >= 0)
                {
                    vowels++;
                }
                // Check if character is a digit
                else if (char.IsDigit(ch))
                {
                    digits++;
                }
                // Check if character is a consonant
                else if (char.IsLetter(ch))
                {
                    consonants++;
                }
                // Count all other characters as "other"
                else
                {
                    others++;
                }
            }

            // Display results
            Console.WriteLine("consonants: " + consonants);
            Console.WriteLine("vowels: " + vowels);
            Console.WriteLine("digits: " + digits);
            Console.WriteLine("other: " + others);
        }
    }
}