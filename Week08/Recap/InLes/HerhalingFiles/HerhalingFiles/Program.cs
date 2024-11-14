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

        }
    }
}
