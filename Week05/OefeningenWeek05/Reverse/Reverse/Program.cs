using System;
using System.IO;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the filename
            Console.WriteLine("Enter the file name:");
            string inputFileName = Console.ReadLine();

            // Check if the file exists
            if (!File.Exists(inputFileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            // Create the output filename
            string outputFileName = $"reverse_{inputFileName}";

            try
            {
                // Read all lines from the input file
                string[] lines = File.ReadAllLines(inputFileName);

                // Reverse the order of the lines
                Array.Reverse(lines);

                // Write the reversed lines to the output file
                File.WriteAllLines(outputFileName, lines);

                Console.WriteLine($"File created: {outputFileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}