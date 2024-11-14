using System;
using System.IO;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filenaam = Console.ReadLine();
            string reversed = "";

            foreach (var line in File.ReadLines(filenaam))
            {
                reversed = $"{line}\n{reversed}";
            }
            Console.WriteLine(reversed);

            StreamWriter W = File.CreateText($"Reversed_{filenaam}");
            W.WriteLine(reversed);
            W.Close();
        }
    }
}
