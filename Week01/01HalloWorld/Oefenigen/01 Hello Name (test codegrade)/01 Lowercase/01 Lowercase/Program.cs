/*using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your firstname? ");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your favorite animal? ");
            string animal = Console.ReadLine();

            // Artikel "a" toevoegen voor het dier
            Console.WriteLine($"{firstName}, your favorite animal is a {animal.ToLower()}.");
        }
    }
}*/


//Actual solution oefening:

using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();

            string animal = Console.ReadLine();

            Console.WriteLine($"{firstName}, your favorite animal is {animal.ToLower()}");
        }
    }
}
