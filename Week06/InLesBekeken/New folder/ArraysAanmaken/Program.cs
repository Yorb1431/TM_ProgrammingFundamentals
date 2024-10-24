using System;
namespace ArraysAanmaken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //een array aanmaken
            int[] intArray = new int[10]; //alle waarden zijn 0
            string[] stringArray = new string[4]; //alle waarden ""

            double[] doubles = { 1.5, 9, 10.0, -6, 12, 5.6 };
            Console.WriteLine(doubles.Length);

            int[] ints = { 1, 3, 8, 23, 99 };
        }
    }
}
