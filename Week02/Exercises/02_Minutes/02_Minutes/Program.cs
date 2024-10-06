using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read in minutes and convert it to seconds and hours.
                
                Input/Output:
                        input:
                            71
                        output:
                            4260 seconds
                            1 hour(s)
                        input:
                            508
                        output:
                            30480 seconds
                            8 hour(s)
             */

            // Read in the number of minutes
            int minutes = Convert.ToInt32(Console.ReadLine());

            // Convert minutes to seconds
            int seconds = minutes * 60;

            // Convert minutes to hours
            int hours = minutes / 60;

            // Output the result
            Console.WriteLine(seconds + " seconds");
            Console.WriteLine(hours + " hour(s)");
        }
    }
}
