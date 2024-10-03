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
        }
    }
}
