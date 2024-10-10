using System;
namespace _03WeekHerhaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Schrijf een programma dat gebaseerd is op de nummer van de maand
             de effectieve naam van de maand toont.

             TryParse gebruiken
             Verplicht nesten
             Verplicht switch case
                 switch()
                     {
                         case...:
                             break;
                         Default;
                     }

             Alles dat geen valide maandnummer is, crazy input
             */

            bool number = Int32.TryParse(Console.ReadLine(), out int month);
            if (number) // Removed semicolon here
            {
                if (month > 0 && month <= 12) // Changed to month <= 12
                {
                    switch (month)
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
                        default:
                            Console.WriteLine("December"); 
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Crazy input");
                }
            }
            else
            {
                Console.WriteLine("Crazy input! Please enter a valid number.");
            }
        }
    }
}
