using System;
namespace _04_BigOrSmallPond
{
    internal class Program
    {
        static void Main()
        {
            // Lees de diepte van de vijver van de gebruiker
            int diepte = Convert.ToInt32(Console.ReadLine());

            // Doorloop elke rij, van boven naar beneden
            for (int rij = 0; rij < diepte; rij++)
            {
                // Bouw de linkerkant van de vijver (nullen aan het begin van elke rij)
                for (int i = 0; i <= rij; i++) // Let op de "i <= rij", omdat elke rij begint met 'rij + 1' nullen
                {
                    Console.Write("0 ");
                }

                // Bouw het midden van de vijver (water '~'), dit verschijnt tussen de nullen
                for (int j = 0; j < (2 * (diepte - rij) - 2); j++) // De hoeveelheid water ('~') neemt af
                {
                    Console.Write("~ ");
                }

                // Bouw de rechterkant van de vijver (nullen aan het eind van elke rij)
                for (int k = 0; k <= rij; k++) // Let op de "k <= rij", omdat elke rij eindigt met 'rij + 1' nullen
                {
                    Console.Write("0 ");
                }

                // Ga naar de volgende regel voor de volgende rij
                Console.WriteLine();
            }
        }
    }
}