using System;
namespace Week06_Ending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input
            string invoer = Console.ReadLine();

            // Split input into two words
            string[] woorden = invoer.Split(' ');
            string nummer1 = woorden[0];
            string Wooord2 = woorden[1];

            int lengte1 = nummer1.Length;
            int lengte2 = Wooord2.Length;
            int matchLengte = 0;

            // Loop from the end of both strings to find common ending
            while (matchLengte < lengte1 && matchLengte < lengte2)
            {
                if (nummer1[lengte1 - 1 - matchLengte] == Wooord2[lengte2 - 1 - matchLengte])
                {
                    matchLengte++;
                }
                else
                {
                    break;
                }
            }

            // Output the common ending if found
            if (matchLengte > 0)
            {
                string gemeenschappelijkEinde = nummer1.Substring(lengte1 - matchLengte);
                Console.WriteLine(gemeenschappelijkEinde);
            }
            else
            {
                Console.WriteLine("output:");

            }
        }
    }
}
