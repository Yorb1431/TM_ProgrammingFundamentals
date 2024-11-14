using System;
namespace FloydsTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lijnen = Convert.ToInt32(Console.ReadLine());
            int teller = 1;

            for (int i = 1; i <= lijnen; i++)
            {
                // Adjust inner loop to run 'i' times for each row
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{teller} ");
                    teller++;
                }
                Console.WriteLine();
            }
        }
    }
}
