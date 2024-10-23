using System;
namespace _04_Current_and_previous_Fibonacci
{
    internal class Program
    {
        static void Main()
        {
            // Lees de invoer van de gebruiker
            int n = int.Parse(Console.ReadLine());

            // Speciale gevallen voor n == 0 en n == 1
            if (n == 0)
            {
                Console.WriteLine("Previous: 0 and current: 0");
                return;
            }
            else if (n == 1)
            {
                Console.WriteLine("Previous: 0 and current: 1");
                return;
            }

            // Beginwaarden voor de Fibonacci-reeks
            int vorig = 0; // F(0)
            int Nu = 1; // F(1)

            // Bereken de Fibonacci-waarden tot de n-de positie
            for (int i = 2; i <= n; i++)
            {
                int volgende = vorig + Nu; // F(n) = F(n-1) + F(n-2)
                vorig = Nu; // Verplaats de huidige naar de vorige
                Nu = volgende; // Update de huidige naar de volgende
            }

            // Druk het resultaat af
            Console.WriteLine($"Previous: {vorig} and current: {Nu}");
        }
    }
}