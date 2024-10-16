using System;

namespace _03_Curzon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input
            string input = Console.ReadLine();

            // Declare the variable
            int Nummer;
            bool booltje = int.TryParse(input, out Nummer);  // Correctly using Nummer

            // Check if input is a valid non-negative integer
            if (!booltje || Nummer < 0)
            {
                Console.WriteLine("crazy input");
            }
            else
            {
                // Calculate 2^N + 1 and 2*N + 1
                int astictje = (int)Math.Pow(2, Nummer) + 1;
                int maaltafel = 2 * Nummer + 1;

                // Check if Curzon number condition is satisfied
                if (astictje % maaltafel == 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
