using System;
namespace count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int vowels = 0;
            int consonants = 0;
            int digits = 0;
            int others = 0;

            foreach (char ch in input)
            {
                if (ch == ' ') continue;

                if ("aeiouAEIOU".IndexOf(ch) >= 0)
                {
                    vowels++;
                }
                else if (char.IsDigit(ch))
                {
                    digits++;
                }
                else if (char.IsLetter(ch))
                {
                    consonants++;
                }
                else
                {
                    others++;
                }
            }

            Console.WriteLine("consonants: " + consonants);
            Console.WriteLine("vowels: " + vowels);
            Console.WriteLine("digits: " + digits);
            Console.WriteLine("other: " + others);
        }
    }
}