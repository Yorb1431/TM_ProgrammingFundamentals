using System;

namespace WorksheetLes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.WriteLine("Geef een getal");

            // Try to parse input as an integer
            if (int.TryParse(Console.ReadLine(), out int getal))
            {
                // If statements
                if (getal < 50) {
                    Console.WriteLine("Getal kleiner dan 50");
                }
                else if (getal == 50) {

                    Console.WriteLine("Getal is 50");
                }
                else {
                    Console.WriteLine("Getal is groter dan 50");
                }
            }


            //If statement gezien als aparte id werk met vaste structuur
            Console.WriteLine();
            Console.WriteLine("Test periode");
            if (getal < 50)
            {
                Console.WriteLine("Getal is groter als 50");
            }
            if (getal == 50)
            {
                Console.WriteLine("Getal is 50");
            }
            else {
                Console.WriteLine("Getal is groter als 50");
            }




            //Optie 2 if statement
            if (getal < 50) {
                Console.WriteLine("kleiner");
            }
            else {
                if (getal == 50)
                    Console.WriteLine("Gelijk");

                else {
                    Console.WriteLine("Groter");
                }
            }

            //optie 3 --> combineren van if's
            if (getal != 50) //verschillend van 50
            {
                if (getal < 50)
                {
                    Console.WriteLine("Kleiner dan 50");
                }
                else
                {
                    Console.WriteLine("Groter dan 50");
                }
            }
            else //Dus uitvoeren als getal wel exact 50 is.
            {
                Console.WriteLine("Gelijk aan 50");
            }

            //optie 4: if in een else versie 2
            if (getal > 50)
            {
                Console.WriteLine("Groter dan 50");
            }
            else
            {
                if (getal == 50)
                {
                    Console.WriteLine("Gelijk aan 50");
                }
                else
                {
                    Console.WriteLine("Kleiner dan 50");
                }
            }


            //Combinaties maken en controleren
            // controlere of getal gekijk of niet gelijk is aan 50

            // Optie 1
            if (getal == 50)
            {
                Console.WriteLine("exact 50");
            }
            else {
                Console.WriteLine("Niet 50");
            }

            //Optie 2
            if (getal < 50)


        }
    }
}
