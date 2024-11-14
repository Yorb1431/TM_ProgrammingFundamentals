using System;
namespace Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stap 1: Lees array
            // Stap 2: Loop door getal en controleer of het even of oneven is
            // Stap 3: Vervang getallen door "Even" of "Odd"
            // Stap 4: Print array


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

            string[] output = new string[som];
            for (int i = 0; i < som; i++)
            {
                if (getal[i] % 2 == 0)
                {
                    output[i] = "Even";
                }
                else
                {
                    output[i] = "Odd";
                }
            }

            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}