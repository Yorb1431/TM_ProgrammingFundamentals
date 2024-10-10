using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace _04WeekInLesTheory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // maaltafel van een getal
            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            //Idiote versie
            Console.WriteLine($"{getal} * 1 = {getal * 1}");
            Console.WriteLine($"{getal} * 2 = {getal * 2}");
            Console.WriteLine($"{getal} * 3 = {getal * 3}");
            Console.WriteLine($"{getal} * 4 = {getal * 4}");



            // Betere versie

        }
    }
}
