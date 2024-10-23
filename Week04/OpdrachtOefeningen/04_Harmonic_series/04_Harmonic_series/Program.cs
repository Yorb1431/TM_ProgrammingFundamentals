using System;
namespace _04_Harmonic_series
{
    internal class Program
    {
        static void Main()
        {
            int termijnen = int.Parse(Console.ReadLine());

            if (termijnen <= 0)
            {
                Console.WriteLine("crazy input");
                return;
            }

            double sum = 0.0;

            for (int i = 1; i <= termijnen; i++)
            {
                sum += 1.0 / i;

                if (i == termijnen)
                {
                    Console.Write($"1/{i}");
                }
                else
                {
                    Console.Write($"1/{i} + ");
                }
            }

            Console.WriteLine($"\nsum = {Math.Round(sum, 5)}");
        }
    }
}