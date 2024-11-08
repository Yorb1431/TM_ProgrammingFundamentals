using System;
namespace _05_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input string
            string input = Console.ReadLine();

            // Result variable to store unique characters
            string result = "";

            // Loop through each character in the input string
            foreach (char ch in input)
            {
                // If the character is not already in the result string, add it
                if (!result.Contains(ch))
                {
                    result += ch;
                }
            }

            // Display the result with duplicates removed
            Console.WriteLine(result);
        }
    }
}
