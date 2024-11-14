using System;
namespace Missing06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stap 1: Definieer main om input te lezen
            // Stap 2: Parse input
            // Stap 3: gebruik 1 tot arraylengte + 1
            // Stap 4: variabele voor som van 1 tot n
            // Stap 5: Bereken  som van array
            // Stap 6: Vind ontbrekend getal door werkelijke som af te trekken van verwachte som
            // Stap 7: print output



            string input = Console.ReadLine();

            int[] getalln = new int[input.Length];
            int a = 0;
            int GetalInGebruik = 0;

            for (int i = 0; i <= input.Length; i++)
            {
                if (i < input.Length && char.IsDigit(input[i]))
                {
                    GetalInGebruik = GetalInGebruik * 10 + (input[i] - '0');
                }
                else if ((i == input.Length) || (i < input.Length && input[i] == ' '))
                {
                    if (GetalInGebruik != 0)
                    {
                        getalln[a] = GetalInGebruik;
                        a++;
                    }
                    GetalInGebruik = 0;
                }
            }

            int n = a + 1;
            int expectedSum = n * (n + 1) / 2;
            int som = 0;

            for (int i = 0; i < a; i++)
            {
                som += getalln[i];
            }

            int missingNumber = expectedSum - som;

            if (missingNumber == 0)
            {
                Console.WriteLine("There is no missing link!");
            }
            else
            {
                Console.WriteLine(missingNumber);
            }
        }
    }
}