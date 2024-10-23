using System;
namespace _04_Mix_it_up
{
    internal class Program
    {
        static void Main()
        {
            // Lees twee strings van de gebruiker
            string woord01 = Console.ReadLine();
            string woord02 = Console.ReadLine();

            // Bepaal welk woord langer is
            string langWoord = woord01.Length >= woord02.Length ? woord01 : woord02;
            string kortWoord = woord01.Length < woord02.Length ? woord01 : woord02;

            // Variabele om het resultaat op te slaan
            string gemixtWoord = "";

            // Loop door de karakters van beide woorden
            for (int i = 0; i < langWoord.Length; i++)
            {
                // Voeg karakter van het langste woord toe als het bestaat
                if (i < langWoord.Length)
                {
                    gemixtWoord += langWoord[i];
                }

                // Voeg karakter van het kortste woord toe als het bestaat
                if (i < kortWoord.Length)
                {
                    gemixtWoord += kortWoord[i];
                }
            }

            // Druk het gemixte woord af
            Console.WriteLine(gemixtWoord);
        }
    }
}