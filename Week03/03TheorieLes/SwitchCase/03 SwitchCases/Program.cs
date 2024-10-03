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














        }
    }
}
