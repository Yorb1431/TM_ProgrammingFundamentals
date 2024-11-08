using System;
namespace _05_Punctuation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Read the input string
            string zin = Console.ReadLine();
            string gecorrigeerdeZin = ""; // This will hold the corrected sentence
            bool vorigeWasLeesteken = false; // Flag to track if the previous character was punctuation

            // Step 2: Loop through each character in the input string
            foreach (char teken in zin)
            {
                // Check if the current character is punctuation
                if (".,?!-:(){}[];\"'".Contains(teken))
                {
                    // If we already added a punctuation mark, skip adding this one
                    if (!vorigeWasLeesteken)
                    {
                        gecorrigeerdeZin += teken;
                        vorigeWasLeesteken = true; // Mark that the last added character was punctuation
                    }
                }
                else
                {
                    // If it's not punctuation, add it to the sentence and reset flag
                    gecorrigeerdeZin += teken;
                    vorigeWasLeesteken = false;
                }
            }

            // Step 3: Output the corrected sentence
            Console.WriteLine(gecorrigeerdeZin);
        }
    }
}