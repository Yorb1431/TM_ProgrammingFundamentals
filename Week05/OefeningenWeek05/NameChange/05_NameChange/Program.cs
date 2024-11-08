using System;
using System.IO;
namespace _05_NameChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Ask user for the filename and new name
            string fileName = Console.ReadLine();

            // Step 2: Validate the file name existence
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"Error: File {fileName} not found.");
                return;
            }

            string newName = Console.ReadLine();

            // Step 3: Validate the new name (ensure it's not empty or a number)
            if (int.TryParse(newName, out _) || string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine($"{newName} is not a name.");
                return;
            }

            // Step 4: Read the file content
            try
            {
                string content = File.ReadAllText(fileName);

                // Step 5: Get the old name (from the file name without extension)
                string oldName = Path.GetFileNameWithoutExtension(fileName); // Extract the base name (e.g., "Alex" from "Alex.txt")

                // Step 6: Replace occurrences of old name with new name in the content
                string updatedContent = content.Replace(oldName, newName);

                // Step 7: Output the updated content
                Console.WriteLine(updatedContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }
        }
    }
}