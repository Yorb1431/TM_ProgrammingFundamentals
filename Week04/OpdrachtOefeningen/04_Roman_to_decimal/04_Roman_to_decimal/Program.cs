using System;
using System.Linq;
namespace _04_Roman_to_decimal
{
    internal class Program
    {
        static void Main()
        {
            // Lees de Romeinse cijferinvoer van de gebruiker
            string romanNummer = Console.ReadLine();

            int decimaalGetal = 0;
            int EerderNummer = 0;

            // Loop door de Romeinse cijfers van achteren naar voren
            for (int i = romanNummer.Length - 1; i >= 0; i--)
            {
                char NuChar = romanNummer.ElementAt(i);
                int NuEnding = 0;

                // Gebruik switch case om de waarde van het Romeinse cijfer te bepalen
                switch (NuChar)
                {
                    case 'M':
                        NuEnding = 1000;
                        break;
                    case 'D':
                        NuEnding = 500;
                        break;
                    case 'C':
                        NuEnding = 100;
                        break;
                    case 'L':
                        NuEnding = 50;
                        break;
                    case 'X':
                        NuEnding = 10;
                        break;
                    case 'V':
                        NuEnding = 5;
                        break;
                    case 'I':
                        NuEnding = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid Roman numeral");
                        return; // Stop het programma als een ongeldig Romeins cijfer is ingevoerd
                }

                // Controleer of we moeten optellen of aftrekken
                if (NuEnding < EerderNummer)
                {
                    decimaalGetal -= NuEnding; // Aftrekken
                }
                else
                {
                    decimaalGetal += NuEnding; // Optellen
                }

                // Update previousValue voor de volgende iteratie
                EerderNummer = NuEnding;
            }

            // Druk de resulterende decimale waarde af
            Console.WriteLine(decimaalGetal);
        }
    }
}