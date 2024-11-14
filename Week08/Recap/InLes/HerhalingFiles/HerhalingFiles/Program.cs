using System;
using System.IO;
namespace HerhalingFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Optie 01
            StreamReader sr = File.OpenText("Rapunzel.txt");
            string text = sr.ReadToEnd();
            sr.Close();

            //Otie 02

        }
    }
}
