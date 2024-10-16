using System;
namespace _03_Numerical_to_letter_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cijfer;

            bool Valid = int.TryParse(input, out cijfer);

            // Check if the input is a valid grade between 0 and 100
            if (!Valid || cijfer < 0 || cijfer > 100)
            {
                Console.WriteLine("crazy input");
            }
            else
            {
                // Initialize letter grade variable
                string EindCijfer = "";

                // Determine the letter grade using switch
                switch (cijfer / 10)
                {
                    case 10: // This case should not happen
                    case 9:
                        EindCijfer = "A";
                        break;
                    case 8:
                        EindCijfer = "B";
                        break;
                    case 7:
                        EindCijfer = "C";
                        break;
                    case 6:
                        EindCijfer = "D";
                        break;
                    default: // This covers grades 0-5
                        EindCijfer = "F";
                        break;
                }

                // Add + or - suffix if needed
                if (EindCijfer != "F")
                {
                    if (cijfer % 10 >= 7)
                    {
                        EindCijfer += "+"; // Add + if the remainder is 7 or more
                    }
                    else if (cijfer % 10 < 3)
                    {
                        EindCijfer += "-"; // Add - if the remainder is less than 3
                    }
                }

                // Output the final letter grade
                Console.WriteLine(EindCijfer);
            }
        }
    }
}