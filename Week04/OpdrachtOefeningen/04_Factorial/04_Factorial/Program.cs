using System;
namespace _04_Factorial
{
    internal class Program
    {
        static void Main()
        {
            // Lees een niet-negatief geheel getal van de gebruiker
            string input = Console.ReadLine();
            int n;

            // Probeer de invoer te converteren naar een geheel getal
            if (!int.TryParse(input, out n) || n < 0)
            {
                Console.WriteLine("crazy input");
                return; // Stop het programma als de invoer ongeldig is
            }

            // Variabele om het resultaat van de faculteit op te slaan
            long factorial = 1;

            // Bereken de faculteit van n
            for (int i = 1; i <= n; i++)
            {
                factorial *= i; // Vermenigvuldig de faculteit met i
            }

            // Druk het resultaat van de faculteit af
            Console.WriteLine(factorial);
        }
    }
}