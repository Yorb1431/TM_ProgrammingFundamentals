using System;
namespace Pangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the input string
            string invoer = Console.ReadLine().ToLower();

            // Call the method to check if it's a pangram
            bool isPangram = IsPangram(invoer);

            // Output the result
            Console.WriteLine(isPangram);
        }

        static bool IsPangram(string invoer)
        {
            // Create a boolean array to track each letter of the alphabet
            bool[] gevondenLetters = new bool[26];
            int aantalLetters = 0;

            // Loop through each character in the string
            foreach (char teken in invoer)
            {
                // Check if the character is a letter
                if (teken >= 'a' && teken <= 'z')
                {
                    // Calculate the index for the letter
                    int index = teken - 'a';

                    // If the letter is not found yet, mark it as found
                    if (!gevondenLetters[index])
                    {
                        gevondenLetters[index] = true;
                        aantalLetters++;

                        // If we have found all 26 letters, we can return true early
                        if (aantalLetters == 26)
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
