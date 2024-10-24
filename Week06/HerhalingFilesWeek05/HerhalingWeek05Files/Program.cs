using System;
using System.IO;
namespace HerhalingWeek05Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Optie 01

          
            int amount = Convert.ToInt32(Console.ReadLine());
            int counter  = 0;
            /*
          StreamWriter sr = File.CreateText(@"Harry Potter and the Sorcerer.txt");
          foreach (string line in File.ReadLines($"Harry-{amount}.txt"))
          {
              if (counter <= amount)
              {
                  sr.WriteLine($"{counter} {line}");
                  counter++;
              }
              else break;
          }
          sr.Close(); */

            //Optie 02
            StreamWriter schrijf = File.CreateText($"Harry-{amount}-optie02.txt");
            StreamReader lees = File.OpenText(@"Harry Potter and the Sorcerer.txt");

            counter = 0; //Resest counter
            while (counter <= amount)
            {
                schrijf.WriteLine(counter + " "  + lees.ReadLine());
            }
            lees.Close();
            schrijf.Close();

        }
    }
}
