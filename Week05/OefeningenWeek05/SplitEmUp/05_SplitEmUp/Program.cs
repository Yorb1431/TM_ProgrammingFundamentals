using System;
using System.IO;
namespace _05_SplitEmUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Read the file name
            string fileName = Console.ReadLine();

            // Step 2: Check if the file exists
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Error: The file does not exist.");
                return;
            }

            // Step 3: Read the contents of the file
            string fileContent = File.ReadAllText(fileName);

            // Step 4: Split the file content into two alternating strings
            // We assume that the length of the content is even for simplicity
            char[] firstSentence = new char[fileContent.Length / 2];
            char[] secondSentence = new char[fileContent.Length / 2];

            int firstIndex = 0;
            int secondIndex = 0;

            // Step 5: Alternate between characters from the two sentences
            for (int i = 0; i < fileContent.Length; i++)
            {
                if (i % 2 == 0) // Even index: Take from first sentence
                {
                    firstSentence[firstIndex++] = fileContent[i];
                }
                else // Odd index: Take from second sentence
                {
                    secondSentence[secondIndex++] = fileContent[i];
                }
            }

            // Step 6: Convert the character arrays to strings
            string firstSentenceStr = new string(firstSentence);
            string secondSentenceStr = new string(secondSentence);

            // Step 7: Output the reconstructed sentences
            Console.WriteLine(firstSentenceStr);
            Console.WriteLine(secondSentenceStr);
        }
    }
}