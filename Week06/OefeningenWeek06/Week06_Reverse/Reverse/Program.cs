using System;
namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stap 1: Lees string
            // Stap 2: splits in array van woorden
            // Stap 3: Maak nieuwe array voor omgekeerde woorden
            // Stap 3: Loop  woorden en keer elk woord om
            // Stap 4: Sla omgekeerde woorden in de nieuwe array
            // Stap 5: Print nieuwe array


            string input = Console.ReadLine();
            string omgedraaid = "";
            string woord = "";

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == ' ' || i == input.Length - 1)
                {
                    if (i == input.Length - 1 && ch != ' ')
                    {
                        woord += ch;
                    }

                    for (int j = woord.Length - 1; j >= 0; j--)
                    {
                        omgedraaid += woord[j];
                    }

                    if (ch == ' ')
                    {
                        omgedraaid += " ";
                    }

                    woord = "";
                }
                else
                {
                    woord += ch;
                }
            }

            Console.WriteLine($"{omgedraaid} ");
        }
    }
}