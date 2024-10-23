using System;
namespace _04_Even_Steven
{
    internal class Program
    {
        static void Main()
        {
            // Lees de eerste twee gehele getallen (grenzen) van de gebruiker
            int eersteGetal = Convert.ToInt32(Console.ReadLine());
            int tweedeGetal = Convert.ToInt32(Console.ReadLine());

            // Bepaal de kleinere en grotere grens (maakt niet uit welke volgorde ze zijn ingevoerd)
            int lagereGrens = Math.Min(eersteGetal, tweedeGetal);
            int hogereGrens = Math.Max(eersteGetal, tweedeGetal);

            // Variabele om het product van alle even getallen op te slaan, beginnen met 1 (neutraal element voor vermenigvuldiging)
            int product = 1;

            // Doorloop alle getallen tussen de lagere en hogere grens, inclusief grenzen
            for (int i = lagereGrens; i <= hogereGrens; i++)
            {
                // Controleer of het getal even is
                if (i % 2 == 0)
                {
                    // Vermenigvuldig het product met het huidige even getal
                    product *= i;
                }
            }

            // Druk het uiteindelijke product af
            Console.WriteLine(product);
        }
    }
}