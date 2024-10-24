using System;
namespace Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D array aanmaken
            int[,] ints = new int[4, 5];
            string[,] fruit = { { "appel", "peer", "pompelmoes", "banaan"},
            {"limoen", "watermeloen", "aardbei", "lychee" },
            {"druif", "granaatappel", "perzik", "appelsien" } };

            //waarden opvragen
            //reminder: index start bij 0,0
            Console.WriteLine($"element in rij 1 col 1: {fruit[0, 0]}");
            Console.WriteLine($"element in rij 2 col 2: {fruit[1, 1]}");

            fruit[1, 1] = "citroen";
            Console.WriteLine($"element in rij 2 col 2: {fruit[1, 1]}");

        }
    }
}
