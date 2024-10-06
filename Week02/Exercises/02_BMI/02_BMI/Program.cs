using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read in the person's weight in kilograms (kg) and their height in metres (m). 
                Calculate the person's BMI and round it to 2 digits.

                Use the following formula: BMI = kg / m²

                Problems with . as the decimal separator? Add this line of code in your Main-method before you start reading input from the console:
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            */

            // Add this line to handle . as the decimal separator
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            // Read in the person's weight in kg
            double gewicht = Convert.ToDouble(Console.ReadLine());

            // Read in the person's height in meters
            double lengte = Convert.ToDouble(Console.ReadLine());

            // Calculate the BMI
            double BMI = gewicht / (lengte * lengte);

            // Print the rounded BMI value (rounded to 2 decimal places)
            Console.WriteLine(Math.Round(BMI, 2));
        }
    }
}
