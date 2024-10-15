using System;

namespace _03_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the correct PIN using Convert.ToInt32
            Console.WriteLine("Enter your correct PIN:");
            int JuistPIN = Convert.ToInt32(Console.ReadLine());

            // First attempt
            Console.WriteLine("Enter your PIN to withdraw:");
            int PIN = Convert.ToInt32(Console.ReadLine());

            if (PIN == JuistPIN)
            {
                Console.WriteLine("Succesful withdrawal");
            }
            else
            {
                // Second attempt (since first attempt was wrong)
                Console.WriteLine("Enter your PIN again:");
                PIN = Convert.ToInt32(Console.ReadLine());

                if (PIN == JuistPIN)
                {
                    Console.WriteLine("Succesful withdrawal");
                }
                else
                {
                    // Third attempt (since second attempt was wrong)
                    Console.WriteLine("Enter your PIN again:");
                    PIN = Convert.ToInt32(Console.ReadLine());

                    if (PIN == JuistPIN)
                    {
                        Console.WriteLine("Succesful withdrawal");
                    }
                    else
                    {
                        // If all three attempts are wrong
                        Console.WriteLine("Too many attempts");
                    }
                }
            }
        }
    }
}
