using System;
namespace Progam01InLES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input en output
            //omzetten van datatypes

            Console.WriteLine("Geef een naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine(naam);


            //omzetting
            Console.Write("Geef een getal: ");
            string antwoord= Console.ReadLine();
            int getal = Convert.ToInt32(antwoord);
            Console.WriteLine(antwoord);










        }
    }
}
