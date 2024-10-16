using System;

namespace TriangleTypeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the sides of the triangle
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double side3 = double.Parse(Console.ReadLine());

            // Check if each side is positive
            if (side1 <= 0)
            {
                Console.WriteLine("crazy input");
            }
            else if (side2 <= 0)
            {
                Console.WriteLine("crazy input");
            }
            else if (side3 <= 0)
            {
                Console.WriteLine("crazy input");
            }
            else
            {
                // Determine the type of triangle
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("equilateral");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("isosceles");
                }
                else
                {
                    Console.WriteLine("scalene");
                }
            }
        }
    }
}
