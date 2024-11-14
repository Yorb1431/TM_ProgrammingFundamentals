using System;
namespace Rotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stap 1: Lees array
            // Stap 2: Lees aantal rotaties
            // Stap 3: Bereken nieuwe index voor elk element
            // Stap 4: Maak nieuwe array met geroteerde elementen
            // Stap 5: Print nieuwe array


            string input = Console.ReadLine();
            string[] iArray = input.Split(' ');
            int[] array = new int[iArray.Length];

            for (int i = 0; i < iArray.Length; i++)
            {
                array[i] = int.Parse(iArray[i]);
            }

            int rotatie = int.Parse(Console.ReadLine());

            int[] gedraaaideArrey = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int index = (i - rotatie + array.Length) % array.Length;
                gedraaaideArrey[index] = array[i];
            }

            for (int i = 0; i < gedraaaideArrey.Length; i++)
            {
                Console.Write(gedraaaideArrey[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
