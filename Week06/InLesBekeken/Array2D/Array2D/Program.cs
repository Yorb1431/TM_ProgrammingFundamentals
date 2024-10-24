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


            //loopen door arrays
            Console.WriteLine(fruit.Length);
            Console.WriteLine("# rijen : " + fruit.GetLength(0)); //checkt dimensies van array
            Console.WriteLine("# kol : " + fruit.GetLength(1));

            //rijen
            for (int i = 0; i < fruit.GetLength(0); i++)
            {
                for (int j = 0; j < fruit.GetLength(1); j++)
                {
                    Console.Write(fruit[i, j] + "\t"); //\t = horizontal tab
                }
                Console.WriteLine();
            }

            foreach (var item in fruit)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}
