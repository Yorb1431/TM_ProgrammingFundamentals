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

            //^start met tellen vanaf het einde --> ^1 is laatste element, ^2, voorlaatste, ...

            //Waarden koppelen aan arrays
            stringArray[0] = "Dean";
            stringArray[1] = "Tom";
            stringArray[3] = "Jana";
            stringArray[2] = "Mustafa";


            //stringArray[4] = "New guy"; --> index out of range want er zijn maar 4 plaatsen

            Console.WriteLine($"Laatste element van doubles: {doubles[^1]}");
            doubles[5] = 1.0;
            Console.WriteLine($"Laatste element van doubles: {doubles[^1]}");


            //door array loopen
            foreach (var item in stringArray) //gebruik wanneer je niet geeft om index of hoeveel elementen getoond worden
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (string s in stringArray)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();



            //loopen wanneer je wel de index nodig hebt.

            for (int i = 0; i < doubles.Length; i++) //van index 0 - 5
            {
                Console.WriteLine(doubles[i]);
            }

            for (int i = doubles.Length - 1; i >= 0; i--) //van index 5 - 0
            {
                Console.WriteLine(doubles[i]);

            }


            //!!!!!!!!NOOIT GEBRUIKEN AUB!!!!!!! --> WHILE
            int index = 0;
            while (index < doubles.Length)
            {
                Console.WriteLine(doubles[index]);
                index++; //als je dit niet doet, infinite loop
            }


        }
    }
}
