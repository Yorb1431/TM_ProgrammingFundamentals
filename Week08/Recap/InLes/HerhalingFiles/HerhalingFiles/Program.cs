using System;
using System.IO;
namespace HerhalingFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Optie 01

            StreamReader sr = File.OpenText("Rapunzel.txt");
            string text = sr.ReadToEnd();
            sr.Close();
            */

            //Optie 02

            string textvanFile = File.ReadAllText("Rapunzel.txt");
            Console.WriteLine(textvanFile);

            //Optie 03
            StreamReader s = File.OpenText("Rapunzel.txt");
            while (!s.EndOfStream)
            {
                Console.WriteLine(s.ReadLine());
            }
            s.Close();


            //Optie 04
            string[] t = File.ReadAllLines("Rapunzel.txt");
            foreach (var line in t) {
                Console.WriteLine($"-- + {line}");
            }

            //Optie 05
            string textInChar = File.ReadAllText("Rapunzel.txt");
            Console.WriteLine($"{textInChar}");

            foreach (char c in textInChar) {
                if (c == 'i')
                {
                    Console.WriteLine("999");
                } else
                {
                    Console.WriteLine($"{c}");
                }
            }


            //Optie 06
            string TT = File.ReadAllText("Rapunzel.txt");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{TT[^i]}");
            }



            // Schrijven naar FIles



        }
    }
}
