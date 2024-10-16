using System;

namespace _03_Special
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char ch = Console.ReadKey().KeyChar; 
            Console.WriteLine(); 

            if ("aeiouAEIOU".Contains(ch))
            {
                Console.WriteLine("vowel");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("digit");
            }
            else if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine("consonant");
            }
            else
            {
                Console.WriteLine("special character");
            }
        }
    }
}
