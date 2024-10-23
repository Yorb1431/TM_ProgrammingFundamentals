using System;
namespace _04_Prime_Numbers
{
    internal class Program
    {
        static void Main()
        {
            // Lees een geheel getal van de gebruiker
            string input = Console.ReadLine();
            int nummere;

            // Probeer de invoer te converteren naar een geheel getal
            if (!int.TryParse(input, out nummere) || nummere < 2)
            {
                Console.WriteLine("crazy input");
                return; // Stop het programma als de invoer ongeldig is
            }

            // Loop door de getallen van 2 tot n en controleer op priemgetallen
            for (int i = 2; i <= nummere; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " "); // Druk het priemgetal af
                }
            }
        }

        // Methode om te controleren of een getal priem is
        static bool IsPrime(int nummer)
        {
            for (int j = 2; j * j <= nummer; j++) // Controleer tot de wortel van het getal
            {
                if (nummer % j == 0)
                {
                    return false; // Het getal is niet priem
                }
            }
            return true; // Het getal is priem
        }
    }
}