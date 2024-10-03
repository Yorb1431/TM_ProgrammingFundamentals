﻿using System;
namespace _03_SwitchCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //info datums gecombineerd met SWITCH CASES
            int weekdag = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(weekdag);

            string dagInWoorden = DateTime.Now.DayOfWeek.ToString();
            Console.WriteLine(dagInWoorden);

            //Console.WriteLine(DateTime.Now); --> alle gegevens die we bijhouden

            DateTime yesterday = new DateTime(2024, 10, 02);
            string dag = yesterday.DayOfWeek.ToString();
            Console.WriteLine(yesterday); // 02/10/2024 00:00:00

            DateTime verjaardag = new DateTime(2005, 05, 11); //jjjj,mm,dd
            dag = verjaardag.DayOfWeek.ToString();
            Console.WriteLine(dag);



            if (weekdag == 1)
            {
                Console.WriteLine("Maandag");
            }
            else if (weekdag == 2)
            {
                Console.WriteLine("Dinsdag");
            }
            else if (weekdag == 3)
            {
                Console.WriteLine("Woensdag");
            }
            else if (weekdag == 4)
            {
                Console.WriteLine("Donderdag");
            }
            else if (weekdag == 5)
            {
                Console.WriteLine("Vrijdag");
            }
            else if (weekdag == 6)
            {
                Console.WriteLine("Zaterdag");
            }
            else
            {
                Console.WriteLine("Zondag");
            }
            //bovenstaand voorbeeld met SWITCH

            switch (weekdag)
            {
                case 1:
                    Console.WriteLine("Maandag");
                    break;
                case 2:
                    Console.WriteLine("Dinsdag");
                    break;
                case 3:
                    Console.WriteLine("Woensdag");
                    break;
                case 4:
                    Console.WriteLine("Donderdag");
                    break;
                case 5:
                    Console.WriteLine("Vrijdag");
                    break;
                default:
                    Console.WriteLine("Wohooow weekend");
                    break;
            }

            switch (verjaardag.Day) { 
                case 31:
                    Console.WriteLine("Wat een mooie dag");
                    break;
                case 13:
                    Console.WriteLine("Geboren op een vrijdag, dikke pech");
                    break;
                case 1:
                    Console.WriteLine("Ben je geboren in april, je bent een wandelende mop");
                    break;
                case 7:
                    Console.WriteLine("Lucky number 7");
                    break;
                case 5:
                    Console.WriteLine("Je bent beter als 4");
                    break;
                   default :
                    Console.WriteLine("RIP andere dagen");
                    break;
            }

            //TryParse --> voorkom foutmeldingen
            Console.WriteLine("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is groter dan y");
            }


            // ontwijken if statement
            Console.WriteLine("x = ");
            string answer = Console.ReadLine();
            bool succes = Int32.TryParse(answer, out x); //checkt of gelukt omzetten input naar geheel getal

            if (succes)
            {
                if (x > y)
                {
                    Console.WriteLine("x is groter dan y");
                }
            }
            else
            {
                Console.WriteLine("Crazy output");
            }


            //tryparse deel2
            string antwoord = Console.ReadLine();
            int temp;


            //enkel uitvoeren als de omzetting gelukt is.
            if (Int32.TryParse(antwoord, out temp))
            {
                if (temp < 0)
                {
                    Console.WriteLine("Het is hier koud seg");
                }
                else if (temp == 0)
                {
                    Console.WriteLine("Het is 0 graden");
                }
                else
                {
                    Console.WriteLine("Het is al iets warmer dan 0 grade");
                }
            }
            else
            {
                Console.WriteLine("Dit is geen temperatuur");
            }







        }
    }
}
