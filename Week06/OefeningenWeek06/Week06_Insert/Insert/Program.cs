using System;
namespace Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stap 1: Lees  array en waarde
            // Stap 2: Zoek  positie voor de waarde in array
            // Stap 3: Verschuif elementen na positie één plek op
            // Stap 4: Plaats op de juiste positie
            // Stap 5: Print array


            string input = Console.ReadLine();
            int waarde = int.Parse(Console.ReadLine());

            string[] iArray = input.Split(' ');
            int[] gesorteerd = new int[iArray.Length];

            for (int i = 0; i < iArray.Length; i++)
            {
                gesorteerd[i] = int.Parse(iArray[i]);
            }

            int index = 0;
            while (index < gesorteerd.Length && gesorteerd[index] < waarde)
            {
                index++;
            }

            int[] nieuwewArray = new int[gesorteerd.Length + 1];
            for (int i = 0; i < index; i++)
            {
                nieuwewArray[i] = gesorteerd[i];
            }

            nieuwewArray[index] = waarde;

            for (int i = index; i < gesorteerd.Length; i++)
            {
                nieuwewArray[i + 1] = gesorteerd[i];
            }

            for (int i = 0; i < nieuwewArray.Length; i++)
            {
                Console.Write(nieuwewArray[i]);
                Console.Write(" ");
            }

            Console.WriteLine();

        }
    }
}