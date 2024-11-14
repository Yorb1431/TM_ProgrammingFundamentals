using System;
using System.IO;
using System.Text.RegularExpressions;
namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filenaam = Console.ReadLine();
            Regex rx = new Regex(filenaam.ToLower());

            string txt = File.ReadAllText(filenaam.Replace(" ", "") + ".txt");
            MatchCollection matches = rx.Matches(txt);

            Console.WriteLine($"{matches.Count} occourses of {filenaam}");
        }
    }
}
