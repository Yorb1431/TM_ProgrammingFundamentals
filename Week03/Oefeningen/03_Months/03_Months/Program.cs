using System;
namespace _03_Months
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input
            string input = Console.ReadLine();
            int MaanndNummer;

            // Try to parse the input to an integer
            bool isValid = int.TryParse(input, out MaanndNummer);

            // Check if the input is a valid month number
            if (!isValid || MaanndNummer < 1 || MaanndNummer > 12)
            {
                Console.WriteLine("crazy input");
            }
            else
            {
                // Determine the month name based on the month number using switch
                switch (MaanndNummer)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    case 3:
                        Console.WriteLine("March");
                        break;
                    case 4:
                        Console.WriteLine("April");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("June");
                        break;
                    case 7:
                        Console.WriteLine("July");
                        break;
                    case 8:
                        Console.WriteLine("August");
                        break;
                    case 9:
                        Console.WriteLine("September");
                        break;
                    case 10:
                        Console.WriteLine("October");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                }
            }
        }
    }
}