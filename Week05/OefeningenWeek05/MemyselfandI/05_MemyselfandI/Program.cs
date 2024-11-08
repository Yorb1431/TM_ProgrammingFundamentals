using System;
using System.IO;
using System.Text.RegularExpressions;
namespace _05_MemyselfandI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for the artist name
            Console.WriteLine("Enter the artist name:");
            string artistName = Console.ReadLine().ToLower(); // Convert artist name to lowercase

            // Set the folder path where the .txt files are located
            string folderPath = Directory.GetCurrentDirectory(); // Assuming the files are in the current directory

            // Get all .txt files in the folder
            string[] files = Directory.GetFiles(folderPath, "*.txt");

            // Initialize a counter for occurrences
            int occurrences = 0;

            // Loop through each file
            foreach (var file in files)
            {
                // Read the content of the file
                string content = File.ReadAllText(file).ToLower(); // Read content as lowercase

                // Use regex to find occurrences of the artist's name
                occurrences += CountOccurrences(content, artistName);
            }

            // Output the result
            Console.WriteLine($"{occurrences} occurrences of {artistName}");
        }

        // Method to count occurrences of the artist's name using regex
        static int CountOccurrences(string content, string artistName)
        {
            string pattern = @"\b" + Regex.Escape(artistName) + @"\b"; // Regex pattern for whole word match
            MatchCollection matches = Regex.Matches(content, pattern);

            return matches.Count;
        }
    }
}