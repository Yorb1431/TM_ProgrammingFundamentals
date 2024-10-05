using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read in an integer. Print True if the number is even, otherwise print False.

                Input/Output
                    input:
                        37
                    output:
                        False

                   input:
                        -12
                    output:
                        True             
            */
            // Read in an integer from the user
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is even using modulo, and print the result directly as a boolean expression
            Console.WriteLine(number % 2 == 0);  // This will print True if the number is even, False if odd










        }
    }
}
