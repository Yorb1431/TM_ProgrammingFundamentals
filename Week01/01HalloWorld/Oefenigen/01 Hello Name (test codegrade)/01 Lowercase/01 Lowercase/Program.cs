using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name? ");

            string FirstName = Console.ReadLine();

            Console.WriteLine($"HELLO {FirstName.ToUpper()}");

        }
    }
}
