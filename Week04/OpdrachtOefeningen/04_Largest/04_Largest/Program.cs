using System;
namespace _04_Largest
{
    internal class Program
    {
        static void Main()
        {
            int Biggetal = int.MinValue;

            while (true)
            {
                string inbput = Console.ReadLine();

                if (inbput == "X")
                {
                    break;
                }

                int getal = Convert.ToInt32(inbput);

                if (getal > Biggetal)
                {
                    Biggetal = getal; 
                }
            }

            Console.WriteLine(Biggetal);
        }
    }
}