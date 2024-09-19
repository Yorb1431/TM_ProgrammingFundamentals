using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            int charactersFirstName = FirstName.Length;
            int charactersLastName = LastName.Length;

            Console.WriteLine($"{FirstName} {LastName}, your first name has {charactersFirstName} characters and your last name has {charactersLastName}.");
        }
    }
}
