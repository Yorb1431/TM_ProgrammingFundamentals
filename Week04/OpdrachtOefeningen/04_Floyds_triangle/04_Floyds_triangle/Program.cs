using System;
namespace _04_Floyds_triangle

{
    internal class Program
    {
        static void Main()
        {
            // Lees het aantal regels van de gebruiker
            int lijnen = Convert.ToInt32(Console.ReadLine());

            // Beginwaarde van de teller (we beginnen met 1)
            int getal = 1;

            // Buitenste lus voor elke rij in de driehoek
            for (int lijn = 1; lijn <= lijnen; lijn++)
            {
                // Binnenste lus voor elk element in de rij
                for (int kolom = 1; kolom <= lijn; kolom++)
                {
                    // Druk het huidige nummer af met een spatie na elk getal
                    Console.Write(getal + " ");

                    // Verhoog het nummer voor de volgende iteratie
                    getal++;
                }
                // Start een nieuwe regel na elke rij
                Console.WriteLine();
            }
        }
    }
}