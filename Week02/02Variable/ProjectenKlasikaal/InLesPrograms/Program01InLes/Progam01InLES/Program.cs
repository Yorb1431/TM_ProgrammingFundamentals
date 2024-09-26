using System;

namespace Program01InLES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input en output
            // Omzetten van datatypes

            Console.WriteLine("Geef een naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine(naam);

            // Omzetting
            Console.Write("Geef een getal: ");
            string antwoord = Console.ReadLine();
            int getal = Convert.ToInt32(antwoord);
            Console.WriteLine(getal);

            // Input conversion
            Console.Write("Geef een getal: ");
            string antw = Console.ReadLine();
            int g = Convert.ToInt32(antw);  // Fixed: using the correct input variable 'antw'
            Console.WriteLine(g);

            Console.Write("Geef een byte waarde: ");
            byte b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(b);

            Console.Write("Geef een short waarde: ");
            short s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(s);

            // Byte => byte / short = ToInt16 / int => ToInt32 / long => ToInt64

            // Impliciete en expliciete conversies
            Console.WriteLine(s); // Impliciet --> vanzelf
            Console.WriteLine(s.ToString()); // Expliciet  --> Forceren
            Console.WriteLine(Convert.ToString(s));

            Console.WriteLine();

            // Characters
            Console.WriteLine("Geef een character: ");
            antwoord = Console.ReadLine();
            char c = Convert.ToChar(antwoord);
            Console.WriteLine(c);
            Console.WriteLine((int)c); // ASCII waarde

            // int naamNaarGetal = (int)naam; --> Werkt nooit
            // int stringGetal = (int)"89" --> Werkt ook nooit

            getal = (int)78.3456; // Explicit cast truncates the value
            Console.WriteLine(getal);
            double doubleGetal = 78; // Implicit conversion from int to double
            Console.WriteLine(doubleGetal);
        }
    }
}
