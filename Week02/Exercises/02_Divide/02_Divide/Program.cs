using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Read in two integers, a and b, print true if a can be divided evenly by b. Print false otherwise.
             
                Input/Output
                    input:
                        12
                        3
                    output:
                        True
                    input:
                        12
                        8
                    output:
                        False
             */

            // Read in two integers from the user
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            // Check if a is divisible by b
            bool antwoord = (a % b == 0);

            // Print the result (true or false)
            Console.WriteLine(antwoord);
        }
    }
}
