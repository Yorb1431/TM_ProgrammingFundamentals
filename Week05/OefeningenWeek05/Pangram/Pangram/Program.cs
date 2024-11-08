using System;
namespace Pangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the input string
            Console.WriteLine("Enter a string to check if it's a pangram:");
            string input = Console.ReadLine().ToLower();

            // Call the method to check if it's a pangram
            bool isPangram = IsPangram(input);

            // Output the result
            Console.WriteLine(isPangram);
        }

        static bool IsPangram(string input)
        {
            // Create a boolean array to track each letter of the alphabet
            bool[] lettersFound = new bool[26];
            int lettersCount = 0;

            // Loop through each character in the string
            foreach (char c in input)
            {
                // Check if the character is a letter
                if (c >= 'a' && c <= 'z')
                {
                    // Calculate the index for the letter
                    int index = c - 'a';

                    // If the letter is not found yet, mark it as found
                    if (!lettersFound[index])
                    {
                        lettersFound[index] = true;
                        lettersCount++;

                        // If we have found all 26 letters, we can return true early
                        if (lettersCount == 26)
                        {
                            return true;
                        }
                    }
                }
            }

            // If fewer than 26 letters were found, it's not a pangram
            return false;
        }
    }
}