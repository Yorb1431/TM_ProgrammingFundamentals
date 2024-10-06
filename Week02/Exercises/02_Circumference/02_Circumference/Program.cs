using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read in the length and width of a rectangle and calculate its circumference using the formula 2*(l + w).

                Input/Output
                    input:
                        9
                        35
                    output:
                        88
                
                    input:
                        11
                        3
                    output:
                        28
             */

            // Read in the length and width from the user
            int lengte = Convert.ToInt32(Console.ReadLine());
            int breedte = Convert.ToInt32(Console.ReadLine());

            // Calculate the circumference
            int circumference = 2 * (lengte + breedte);

            // Print the result
            Console.WriteLine(circumference);
        }
    }
}
