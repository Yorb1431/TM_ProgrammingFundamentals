namespace _05_MixAndMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Get the input files and the number of characters to mix
            string file1Name = Console.ReadLine();
            string file2Name = Console.ReadLine();

            int numChars;
            while (!int.TryParse(Console.ReadLine(), out numChars) || numChars < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for the number of characters to mix:");
            }

            // Step 2: Check if the files exist
            if (!File.Exists(file1Name) || !File.Exists(file2Name))
            {
                Console.WriteLine("Error: One or both files do not exist.");
                return;
            }

            // Step 3: Read the contents of both files
            string file1Content = File.ReadAllText(file1Name);
            string file2Content = File.ReadAllText(file2Name);

            // Step 4: Get the number of characters to mix, based on file lengths
            int maxMixLength = numChars;

            // Step 5: Start mixing characters from both files
            char[] mixedResult = new char[maxMixLength];
            int index1 = 0; // Index for file1
            int index2 = 0; // Index for file2

            // Mix characters until the number of required characters is reached
            for (int i = 0; i < maxMixLength; i++)
            {
                // Take from file1 if index1 is within bounds
                if (index1 < file1Content.Length)
                {
                    mixedResult[i] = file1Content[index1];
                    index1++;
                }
                // If file1 is exhausted, take from file2 if index2 is within bounds
                else if (index2 < file2Content.Length)
                {
                    mixedResult[i] = file2Content[index2];
                    index2++;
                }
                // After both files are exhausted, repeat the content from file1 or file2 if needed
                else if (index1 < file1Content.Length)
                {
                    mixedResult[i] = file1Content[index1];
                    index1++;
                }
                else if (index2 < file2Content.Length)
                {
                    mixedResult[i] = file2Content[index2];
                    index2++;
                }
            }

            // Step 6: Output the result
            Console.WriteLine(new string(mixedResult));
        }
    }
}