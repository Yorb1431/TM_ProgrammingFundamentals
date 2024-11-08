using System;
namespace _05_Word_nest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Read the starting word and the final nested word
            string startWord = Console.ReadLine();
            string finalWord = Console.ReadLine();

            // Step 2: Initialize the depth of nesting
            int depth = 0;

            // Step 3: Keep track of the position of the starting word
            while (finalWord.Contains(startWord))
            {
                // Increase depth only when we find an additional layer of nesting
                depth++;

                // Remove one instance of the startWord from finalWord
                finalWord = finalWord.Remove(finalWord.IndexOf(startWord), startWord.Length);
            }

            // Step 4: Output the final depth of nesting
            Console.WriteLine(depth - 1);  // Subtract 1 to correct the extra count
        }
    }
}