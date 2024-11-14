using System;
namespace PositiveAndNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stap 1: Lees string array integers
            // Stap 2: Maak twee lege arrays voor positieve en negatieve getallen
            // Stap 3: Loop door array | voeg getallen toe aan de juiste array
            // Stap 4: Print arrays


            string input = Console.ReadLine();
            char[] grens = new char[] { ' ' };
            string[] stringVanNumbers = input.Split(grens);

            int[] positiveGetalllen = new int[stringVanNumbers.Length];
            int[] negativeGetallen = new int[stringVanNumbers.Length];
            int positieveTelling = 0;
            int negatieVeteller = 0;

            for (int i = 0; i < stringVanNumbers.Length; i++)
            {
                int getal = int.Parse(stringVanNumbers[i]);

                if (getal >= 0)
                {
                    positiveGetalllen[positieveTelling] = getal;
                    positieveTelling++;
                }
                else
                {
                    negativeGetallen[negatieVeteller] = getal;
                    negatieVeteller++;
                }
            }

            for (int i = 0; i < positieveTelling; i++)
            {
                Console.Write(positiveGetalllen[i]);
                if (i < positieveTelling - 1)
                    Console.Write(" ");
            }
            Console.Write(" ");
            Console.WriteLine();

            for (int i = 0; i < negatieVeteller; i++)
            {
                Console.Write(negativeGetallen[i]);
                if (i < negatieVeteller - 1)
                    Console.Write(" ");
            }
            Console.Write(" ");
            Console.WriteLine();
        }
    }
}
