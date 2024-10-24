﻿using System;
namespace ArraysOefInLes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, -3, 6, 9, 2, 3, -4, 5 };

            //gemakkelijke manier
            Console.WriteLine("som: " + array.Sum());
            Console.WriteLine("Max: " + array.Max());
            Console.WriteLine("Min: " + array.Min());
            Console.WriteLine("Gemiddelde: " + array.Average());
            Array.Sort(array);
            Array.Reverse(array);


            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            //algoritmische manier
            //som maken en het gemiddelde berekenen
            array = new int[] { 1, 8, -3, 6, 9, 2, 3, -4, 5 };
            //neemt het origineel terug en overschrijft de array
            int som = 0;
            for (int i = 0; i < array.Length; i++)
            {
                som += array[i];
            }
            Console.WriteLine("som: " + som);
            Console.WriteLine("Gemiddelde: " + som / array.Length);


            //find minimum
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
        }
    }
}
