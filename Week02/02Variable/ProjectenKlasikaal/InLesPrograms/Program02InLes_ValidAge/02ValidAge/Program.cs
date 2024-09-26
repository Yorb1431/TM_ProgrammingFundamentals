using System;
namespace _02ValidAge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int leeftijd = Convert.ToInt32(Console.ReadLine());
            int LegaleBerekening = leeftijd / 2 + 7;
            Console.WriteLine($"Je leeftijd is {leeftijd} en je mag zeker en vast " +
                $"iemand daten vanaf {LegaleBerekening}");
















        }
    }
}
