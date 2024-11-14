using System;
using System.IO;
namespace MixAndMatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = Console.ReadLine();
            string file2 = Console.ReadLine();

            int hoeveel = Convert.ToInt32(Console.ReadLine());
            string F1 = File.ReadAllText(file1);
            string F2 = File.ReadAllText(file2);

            for (int i = 0; i < hoeveel; i++)
            {
                //Console.WriteLine($"{F1[i]} + {F2[i]}"); does not work bc of ascii
                Console.Write($"{F1[i]}");
                Console.Write($"{F2[i]}");

            }
            Console.WriteLine();

        }
    }
}

