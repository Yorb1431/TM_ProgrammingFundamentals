﻿using System;

namespace Basis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read in five numbers and calculate the average. Print average as an integer.

                Problems with . as the decimal separator? Add this line of code in your Main-method before you start reading input from the console:
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                Input/Output
                        input:
                            17.15
                            -3
                            9
                            6.4
                            2
                        output:
                            6

                        input:
                            22.71
                            -15
                            7
                            3.945
                            2
                        output:
                            4
            */

            // Set the culture to handle decimal points
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            // Initialize variables
            double sum = 0;

            // Read and sum five numbers
            sum += Convert.ToDouble(Console.ReadLine());
            sum += Convert.ToDouble(Console.ReadLine());
            sum += Convert.ToDouble(Console.ReadLine());
            sum += Convert.ToDouble(Console.ReadLine());
            sum += Convert.ToDouble(Console.ReadLine());

            // Calculate the average and print it as an integer
            Console.WriteLine((int)(sum / 5));
        }
    }
}
