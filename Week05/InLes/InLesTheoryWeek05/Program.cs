using System;
using System.IO;
namespace InLesTheoryWeek05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File aanmaken
            StreamWriter stream = File.CreateText("file.txt");
            stream.WriteLine("Dit is tekst in in de file"); // Tekst op nieuwe lijn
            stream.Write("Deze tekst start niet op  een niewe lijn"); //Tekst niet op nieuwe lijn
            stream.Write("Mijn naam is P-Jonas");
            stream.Close();



            //Files op andere locaties
            stream = File.CreateText(@"C:\TestFilePromgramming\file.txt");
            stream.WriteLine("Tekstfile in mijn andere locatie");
            stream.Close();
        }
    }
}
