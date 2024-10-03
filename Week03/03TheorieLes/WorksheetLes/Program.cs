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
                if (getal < 50){
                    Console.WriteLine("Getal kleiner dan 50");
                }
                else if (getal == 50){

                    Console.WriteLine("Getal is 50");
                }
                else{
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
            else{
                if (getal == 50)
                    Console.WriteLine("Gelijk");

                else {
                    Console.WriteLine("Groter");
                }
            }







        }
    }
}
