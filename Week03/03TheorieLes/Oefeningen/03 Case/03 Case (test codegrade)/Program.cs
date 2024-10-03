using System;

namespace _03_Case__test_codegrade_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = Convert.ToChar(Console.ReadLine());
            int asci = (int)letter;

            if (asci >= 97 && asci <= 122)
            {
                Console.WriteLine("lowercase");
            }
            else if (asci >= 65 && asci <= 90)  // Fixed condition here
            {
                Console.WriteLine("uppercase");
            }
            else
            {
                Console.WriteLine("Crazy input");
            }
        }
    }
}
