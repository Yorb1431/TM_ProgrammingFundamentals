using System;

namespace _01HalloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats ur name");

            string naam = Console.ReadLine();

            //optie 01
            Console.WriteLine("Hallo, " + naam);

            //Optie 02
            naam = Console.ReadLine();
            Console.WriteLine($"Hello {naam}!");


        }
    }
}

