using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read in three characters and display them in reverse order.

                Input/Output
                    input:
                        t
                        e
                        b
                    output:
                        bet
                    input:
                        n
                        u
                        r
                    output:
                        run
             */

            // Read in three characters from the user
            char first = Convert.ToChar(Console.ReadLine());
            char second = Convert.ToChar(Console.ReadLine());
            char third = Convert.ToChar(Console.ReadLine());

            // Print the characters in reverse order
            Console.WriteLine($"{third}{second}{first}");
        }
    }
}
