using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name? ");
            Console.WriteLine("What's your last name? ");

            string voornaam = Console.ReadLine();
            string achternaam = Console.ReadLine();


            //Optie02
            Console.WriteLine($"Hello {voornaam} {achternaam}");
        }
    }
}
