using System;
namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stap 1: Lees grootte array
            // Stap 2: Lees array in rij per rij
            // Stap 3: Maak nieuwe array met verwisselde rijen en kolommen
            // Stap 4: Print nieuwe array


            int p = int.Parse(Console.ReadLine());
            int[,] array = new int[p, p];

            for (int i = 0; i < p; i++)
            {
                string input = Console.ReadLine();
                int value = 0;
                int column = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    char ch = input[j];

                    if (ch == ' ')
                    {
                        array[i, column] = value;
                        column++;
                        value = 0;
                    }
                    else
                    {
                        value = value * 10 + (ch - '0');
                    }

                    if (j == input.Length - 1 || ch == ' ')
                    {
                        array[i, column] = value;
                    }
                }
            }

            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(array[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
