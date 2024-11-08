using System;
using System.IO;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string origineleBestandsnaam = Console.ReadLine();

            string omgekeerdeBestandsnaam = "reverse_" + origineleBestandsnaam;

            if (!File.Exists(origineleBestandsnaam))
            {
                Console.WriteLine("File not found: " + origineleBestandsnaam);
                return;
            }

            string[] regels = File.ReadAllLines(origineleBestandsnaam);

            string[] omgekeerdeRegels = new string[regels.Length];
            for (int i = 0; i < regels.Length; i++)
            {
                omgekeerdeRegels[i] = regels[regels.Length - 1 - i];
            }

            File.WriteAllLines(omgekeerdeBestandsnaam, omgekeerdeRegels);

            foreach (string regel in omgekeerdeRegels)
            {
                Console.WriteLine(regel);
            }
        }
    }
}
