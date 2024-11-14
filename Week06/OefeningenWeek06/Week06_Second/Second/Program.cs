using System;
namespace Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stap 1: Lees array getallen
            // Stap 2: Zoek grootste getal
            // Stap 3: Zoek 2degrootste getal
            // Stap 4: Print het tweede grootste getal


            string input = Console.ReadLine();
            int[] getal = new int[100];
            int som = 0;
            string nieuwgetal = "";

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == ' ')
                {
                    if (!string.IsNullOrEmpty(nieuwgetal))
                    {
                        getal[som] = int.Parse(nieuwgetal);
                        som++;
                        nieuwgetal = "";
                    }
                }
                else
                {
                    nieuwgetal += ch;
                }
            }

            if (!string.IsNullOrEmpty(nieuwgetal))
            {
                getal[som] = int.Parse(nieuwgetal);
                som++;
            }

            int grootste = int.MinValue;
            int TweedeGrootste = int.MinValue;

            for (int i = 0; i < som; i++)
            {
                if (getal[i] > grootste)
                {
                    TweedeGrootste = grootste;
                    grootste = getal[i];
                }
                else if (getal[i] > TweedeGrootste && getal[i] < grootste)
                {
                    TweedeGrootste = getal[i];
                }
            }

            Console.WriteLine(TweedeGrootste);
        }
    }
}