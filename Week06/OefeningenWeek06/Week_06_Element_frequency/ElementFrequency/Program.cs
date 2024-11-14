using System;
namespace ElementFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stap 1: Lees array  karakters
            // Stap 2: Maak frequentiearray van ASCII-waarde
            // Stap 3: Tel frequentie van elk karakter
            // Stap 4: Print karakters met hun frequentie

            string input = Console.ReadLine();
            char[] ch = input.ToCharArray();

            int[] frequentie = new int[256];
            for (int i = 0; i < ch.Length; i++)
            {
                frequentie[ch[i]]++;
            }

            for (int i = 0; i < frequentie.Length; i++)
            {
                if (frequentie[i] > 0)
                {
                    Console.WriteLine($"Character '{(char)i}': {frequentie[i]} times");
                }
            }
        }
    }
}