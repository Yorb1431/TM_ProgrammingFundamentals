using System;
namespace ArraysAanmaken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //een array aanmaken
            int[] intArray = new int[10]; //alle waarden zijn 0
            string[] stringArray = new string[4]; //alle waarden ""

            double[] doubles = { 1.5, 9, 10.0, -6, 12, 5.6 };
            Console.WriteLine(doubles.Length);

            int[] ints = { 1, 3, 8, 23, 99 };


            //waarden achterhalen van bepaalde plekken in array
            Console.WriteLine("Eerste element van intArray: " + intArray[0]);
            Console.WriteLine($"Laatste element van doubles: {doubles[5]}");
            Console.WriteLine($"Laatste element van doubles: {doubles[doubles.Length - 1]}");
            Console.WriteLine($"Laatste element van doubles: {doubles[^1]}");
            Console.WriteLine($"Laatste element van doubles: {doubles[^2]}");

        }
    }
}
