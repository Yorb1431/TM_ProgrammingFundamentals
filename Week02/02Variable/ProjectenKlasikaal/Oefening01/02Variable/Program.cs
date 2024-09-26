using System;

namespace _02Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            // Werken  rond variable
            // Declareren ervan

            string naam = "Mumba";
            naam = "iets anders";

            char c = 'a';

            // getallen
            int x, y; //Declarenen
            x = 5;
            y = 8;
            Console.WriteLine(x);

            byte nummerByte = 12;
            // nummerByte = 256; ==> Min waarde 0 max Waarden 255

            short nummerShort = 12000;

            long l = 2349637382892929292;

            // kommagetallen
            double nummerDouble = 45.896789; //Niet meer als 15 getallen na komma. 

            float f = 45.32f;

            Console.WriteLine(naam);
            Console.WriteLine(c);
            Console.WriteLine(nummerByte);
            Console.WriteLine(nummerShort);
            Console.WriteLine(nummerDouble);
            Console.WriteLine(f);
            Console.WriteLine(l);


            //Optellen en aftrekken ++ en --
            Console.WriteLine($"x = {x} en y = {y}");
            Console.WriteLine();

            x++; //x = x + 1
            Console.WriteLine($"x = {x}");

            --x;
            Console.WriteLine($"x = {x}");

            // Prefix en postfix
            Console.WriteLine($"x++ geef als resultaat {x++}");
            Console.WriteLine(x); // ==> eigelijk 6 maar we zien 5 op vorige regel
            Console.WriteLine($"++x geef als resultaat {++x}"); // 7
            Console.WriteLine($"x-- geef als resultaat {x--}");
            Console.WriteLine($"--x geef als resultaat {--x}");

            Console.WriteLine();
            // arithmetic (math)
            Console.WriteLine($"x = {x} en y = {y}"); // x= 5 y= 8
            Console.WriteLine($"x + y = {x + y}"); //13
            Console.WriteLine($"x - y = {x - y}"); //-3
            Console.WriteLine($"x * y = {x * y}"); //40
            Console.WriteLine($"x / y = {x / y}"); //0
            //0.625 ==> 2 gehelen getallen delen = negeert afronding
            Console.WriteLine($"5.0 / y = {5.0 / y}");

            //Modulo %
            Console.WriteLine($"10 % 9 = {9 % 10}"); //Hoeveel x gaat 9 in 10


        }
    }
}
