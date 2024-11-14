using System;
using System.IO;

namespace SplitEmUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();

            if (File.Exists(file))
            {
                string txt = File.ReadAllText(file);

                string zin1 = "";
                string zin2 = "";

                for (int i = 0; i < txt.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        zin1 += txt[i];
                    }
                    else
                    {
                        zin2 += txt[i];
                    }
                }
                Console.WriteLine($"Zin 1: {zin1}");
                Console.WriteLine($"Zin 2: {zin2}");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
