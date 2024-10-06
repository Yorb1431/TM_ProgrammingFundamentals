using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read in the area of a circle (A), and calculate the radius using this formula  r = √(A / π). Round the radius to 2 digits. (tip: use Math-library)

                Problems with . as the decimal separator? Add this line of code in your Main-method before you start reading input from the console:
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                Input/Output
                        input:
                            19
                        output:
                            2.46

                        input:
                            13.729
                        output:
                            2.09
            */

            // Set the culture to handle decimal points
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            // Read the area of the circle
            double grond = Convert.ToDouble(Console.ReadLine());

            // Calculate the radius
            double radius = Math.Sqrt(grond / Math.PI);

            // Print the radius rounded to 2 digits
            Console.WriteLine(Math.Round(radius, 2));
        }
    }
}
