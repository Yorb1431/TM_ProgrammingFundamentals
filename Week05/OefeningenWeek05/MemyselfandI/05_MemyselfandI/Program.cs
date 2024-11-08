using System;
using System.IO;
using System.Text.RegularExpressions;
namespace _05_MemyselfandI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string artiesteNaam = Console.ReadLine().ToLower();

            int occurrences = 0;
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");

            foreach (string bestand in files)
            {
                // Lees de inhoud van het bestand
                string inhoud = File.ReadAllText(bestand).ToLower();

                Regex patroon = new Regex(@"\b" + Regex.Escape(artiesteNaam) + @"\b");
                occurrences += patroon.Matches(inhoud).Count;
            }

            Console.WriteLine($"{occurrences} occurrences of {artiesteNaam}");
        }
    }
}
